using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Serviciu pentru logica de business a entității Category.
    /// Conține toate query-urile LINQ, calculele și logica de filtrare.
    /// </summary>
    public class CategoryService
    {
        private readonly IRepository<Category> _categoryRepository;
        private readonly IRepository<Product> _productRepository;

        public CategoryService(IRepository<Category> categoryRepository, IRepository<Product> productRepository = null)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _productRepository = productRepository;
        }

        /// <summary>
        /// Obține toate categoriile active.
        /// </summary>
        public async Task<List<Category>> GetAllActiveAsync()
        {
            return await _categoryRepository
                .GetAll()
                .Where(c => c.IsActive)
                .OrderBy(c => c.CategoryName)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține o categorie cu produsele sale.
        /// </summary>
        public async Task<Category> GetWithProductsAsync(int categoryId)
        {
            return await _categoryRepository
                .GetAll()
                .Where(c => c.CategoryId == categoryId)
                .Include(c => c.Products)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Filtrează categoriile conform criteriilor furnizate.
        /// </summary>
        public async Task<List<Category>> GetFilteredAsync(CategoryFilterCriteria criteria)
        {
            if (criteria == null)
                throw new ArgumentNullException(nameof(criteria));

            IQueryable<Category> query = _categoryRepository.GetAll();

            // Filtru după stare
            if (criteria.IsActive.HasValue)
            {
                query = query.Where(c => c.IsActive == criteria.IsActive.Value);
            }
            else
            {
                query = query.Where(c => c.IsActive);
            }

            // Căutare text
            if (!string.IsNullOrWhiteSpace(criteria.SearchText))
            {
                var searchLower = criteria.SearchText.ToLower();
                query = query.Where(c => c.CategoryName.ToLower().Contains(searchLower));
            }

            // Sortare
            query = ApplySorting(query, criteria.SortBy, criteria.SortOrder);

            // Paginare
            if (criteria.PageSize > 0)
            {
                query = query.Skip((criteria.PageNumber - 1) * criteria.PageSize)
                             .Take(criteria.PageSize);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        /// <summary>
        /// Obține statistici pe categorii (count produse pe categorie).
        /// </summary>
        public async Task<List<dynamic>> GetCategoryStatsAsync()
        {
            return await _categoryRepository
                .GetAll()
                .Where(c => c.IsActive)
                .Include(c => c.Products)
                .AsNoTracking()
                .Select(c => new
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName,
                    ProductCount = c.Products.Count,
                    ActiveProductCount = c.Products.Count(p => p.IsActive)
                })
                .Cast<dynamic>()
                .ToListAsync();
        }

        /// <summary>
        /// Obține produsele dintr-o categorie.
        /// </summary>
        public async Task<List<Product>> GetProductsInCategoryAsync(int categoryId)
        {
            if (_productRepository == null)
                throw new InvalidOperationException("ProductRepository not provided");

            return await _productRepository
                .GetAll()
                .Where(p => p.CategoryId == categoryId && p.IsActive)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Verifică dacă un nume de categorie există deja (case-insensitive).
        /// </summary>
        public async Task<bool> CategoryNameExistsAsync(string categoryName, int? excludeId = null)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
                return false;

            var nameLower = categoryName.ToLower();
            var query = _categoryRepository
                .GetAll()
                .Where(c => c.CategoryName.ToLower() == nameLower);

            if (excludeId.HasValue)
                query = query.Where(c => c.CategoryId != excludeId.Value);

            return await query.AnyAsync();
        }

        /// <summary>
        /// Adaugă o nouă categorie.
        /// </summary>
        public async Task<bool> AddCategoryAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            ValidateCategory(category);

            // Verifică duplicate
            if (await CategoryNameExistsAsync(category.CategoryName))
                throw new InvalidOperationException($"Category '{category.CategoryName}' already exists.");

            try
            {
                _categoryRepository.Add(category);
                await _categoryRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to add category.", ex);
            }
        }

        /// <summary>
        /// Actualizează o categorie existentă.
        /// </summary>
        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            ValidateCategory(category);

            // Verifică duplicate (excluzând ID-ul curent)
            if (await CategoryNameExistsAsync(category.CategoryName, category.CategoryId))
                throw new InvalidOperationException($"Another category with name '{category.CategoryName}' already exists.");

            try
            {
                _categoryRepository.Update(category);
                await _categoryRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to update category.", ex);
            }
        }

        /// <summary>
        /// Deactivează o categorie (soft delete).
        /// </summary>
        public async Task<bool> DeactivateCategoryAsync(int categoryId)
        {
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (category == null)
                return false;

            category.IsActive = false;

            try
            {
                _categoryRepository.Update(category);
                await _categoryRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to deactivate category.", ex);
            }
        }

        /// <summary>
        /// Activează o categorie deactivată.
        /// </summary>
        public async Task<bool> ActivateCategoryAsync(int categoryId)
        {
            var category = await _categoryRepository.GetByIdAsync(categoryId);

            if (category == null)
                return false;

            category.IsActive = true;

            try
            {
                _categoryRepository.Update(category);
                await _categoryRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to activate category.", ex);
            }
        }

        /// <summary>
        /// Obține número de categorii active.
        /// </summary>
        public async Task<int> GetActiveCategoryCountAsync()
        {
            return await _categoryRepository
                .GetAll()
                .Where(c => c.IsActive)
                .CountAsync();
        }

        /// <summary>
        /// Obține categoria după ID.
        /// </summary>
        public async Task<Category> GetByIdAsync(int categoryId)
        {
            return await _categoryRepository.GetByIdAsync(categoryId);
        }

        /// <summary>
        /// Validează datele categoriei.
        /// </summary>
        private void ValidateCategory(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
                throw new ArgumentException("Category name is required.");

            if (category.CategoryName.Length > 100)
                throw new ArgumentException("Category name cannot exceed 100 characters.");
        }

        /// <summary>
        /// Aplică sortarea query-ului.
        /// </summary>
        private IQueryable<Category> ApplySorting(IQueryable<Category> query, string sortBy, string sortOrder)
        {
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "CategoryName";

            var isDescending = sortOrder?.ToLower() == "desc";

            return sortBy.ToLower() switch
            {
                "categoryname" => isDescending 
                    ? query.OrderByDescending(c => c.CategoryName) 
                    : query.OrderBy(c => c.CategoryName),
                "categoryid" => isDescending 
                    ? query.OrderByDescending(c => c.CategoryId) 
                    : query.OrderBy(c => c.CategoryId),
                _ => query.OrderBy(c => c.CategoryName)
            };
        }
    }
}
