using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Serviciu pentru logica de business a entității Product.
    /// Conține toate query-urile LINQ, calculele și logica de filtrare.
    /// </summary>
    public class ProductService
    {
        private readonly IRepository<Product> _productRepository;

        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        /// <summary>
        /// Obține toate produsele active cu Include-urile necesare.
        /// 
        /// SOLID Principle - Cascading Availability:
        /// Include Category pentru a verifica statusul părintelui.
        /// Filtrează NUMAI produsele care sunt:
        /// 1. Activ individual (IsActive == true)
        /// 2. În categorii active (Category.IsActive == true)
        /// 
        /// Aceasta implementează regula cascadă: dacă o categorie este dezactivată,
        /// toate produsele ei devin indisponibile din perspectiva UI,
        /// fără a schimba statusul individual al fiecărui produs în baza de date.
        /// </summary>
        public async Task<List<Product>> GetAllActiveProductsAsync()
        {
            return await _productRepository
                .GetAll()
                .Include(p => p.Category)  // MANDATORY: Pentru a verifica statusul părintelui
                .Include(p => p.Supplier)
                .Where(p => p.IsActive && p.Category.IsActive)  // CASCADING: Ambele trebuie active
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține un produs după ID cu Include-urile necesare.
        /// </summary>
        public async Task<Product> GetProductWithDetailsAsync(int productId)
        {
            return await _productRepository
                .GetAll()
                .Where(p => p.ProductId == productId)
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Filtrează produsele conform criteriilor furnizate.
        /// 
        /// SOLID Principle - Cascading Availability:
        /// Include Category pentru a verifica disponibilitatea cascadă.
        /// Filtrare: produse active ÎN CATEGORII ACTIVE.
        /// </summary>
        public async Task<List<Product>> GetFilteredAsync(ProductFilterCriteria criteria)
        {
            if (criteria == null)
                throw new ArgumentNullException(nameof(criteria));

            IQueryable<Product> query = _productRepository.GetAll()
                .Include(p => p.Category)  // MANDATORY: Pentru cascading availability
                .Include(p => p.Supplier);

            // Filtru după categorie
            if (criteria.CategoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == criteria.CategoryId.Value);
            }

            // Filtru după furnizor
            if (criteria.SupplierId.HasValue)
            {
                query = query.Where(p => p.SupplierId == criteria.SupplierId.Value);
            }

            // CASCADING AVAILABILITY: Filtrează NUMAI produse active ÎN CATEGORII ACTIVE
            if (criteria.IsActive.HasValue)
            {
                query = query.Where(p => p.IsActive == criteria.IsActive.Value && p.Category.IsActive);
            }
            else
            {
                // Implicit, arătăm doar produsele active din categorii active
                query = query.Where(p => p.IsActive && p.Category.IsActive);
            }

            // Filtru pentru produse sub limita de siguranță
            if (criteria.OnlyUnderSafetyLimit == true)
            {
                query = query.Where(p => p.CurrentStock < p.SafetyStock);
            }

            // Filtru după interval de preț
            if (criteria.MinPrice.HasValue)
            {
                var minPriceValue = (double)criteria.MinPrice.Value;
                query = query.Where(p => (double)p.UnitPrice >= minPriceValue);
            }

            if (criteria.MaxPrice.HasValue)
            {
                var maxPriceValue = (double)criteria.MaxPrice.Value;
                query = query.Where(p => (double)p.UnitPrice <= maxPriceValue);
            }

            // Filtru după interval de stoc
            if (criteria.MinStock.HasValue)
            {
                query = query.Where(p => p.CurrentStock >= criteria.MinStock.Value);
            }

            if (criteria.MaxStock.HasValue)
            {
                query = query.Where(p => p.CurrentStock <= criteria.MaxStock.Value);
            }

            // Căutare text
            if (!string.IsNullOrWhiteSpace(criteria.SearchText))
            {
                var searchLower = criteria.SearchText.ToLower();
                query = query.Where(p => p.ProductName.ToLower().Contains(searchLower));
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
        /// Obține produsele cu stoc sub limita de siguranță.
        /// 
        /// CASCADING AVAILABILITY: Include Category pentru filtrare cascadă.
        /// </summary>
        public async Task<List<Product>> GetLowStockProductsAsync()
        {
            return await _productRepository
                .GetAll()
                .Include(p => p.Category)  // Include for cascading availability check
                .Include(p => p.Supplier)
                .Where(p => p.IsActive && p.Category.IsActive && p.CurrentStock < p.SafetyStock)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține valoarea totală a inventarului (sum of UnitPrice * CurrentStock).
        /// Convertează la double pentru compatibilitate cu SQLite.
        /// </summary>
        public async Task<decimal> GetTotalInventoryValueAsync()
        {
            var result = await _productRepository
                .GetAll()
                .Where(p => p.IsActive)
                .Select(p => new
                {
                    Value = (double)p.UnitPrice * p.CurrentStock
                })
                .SumAsync(p => p.Value);

            return (decimal)result;
        }

        /// <summary>
        /// Obține valoarea medie de inventar pe produs.
        /// </summary>
        public async Task<decimal> GetAverageInventoryValueAsync()
        {
            var result = await _productRepository
                .GetAll()
                .Where(p => p.IsActive)
                .Select(p => new
                {
                    Value = (double)p.UnitPrice * p.CurrentStock
                })
                .AverageAsync(p => (double?)p.Value) ?? 0;

            return (decimal)result;
        }

        /// <summary>
        /// Adaugă un produs nou.
        /// </summary>
        public async Task<bool> AddProductAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            ValidateProduct(product);

            try
            {
                _productRepository.Add(product);
                await _productRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to add product.", ex);
            }
        }

        /// <summary>
        /// Actualizează un produs existent.
        /// </summary>
        public async Task<bool> UpdateProductAsync(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            ValidateProduct(product);

            try
            {
                _productRepository.Update(product);
                await _productRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to update product.", ex);
            }
        }

        /// <summary>
        /// Deactivează un produs (soft delete).
        /// </summary>
        public async Task<bool> DeactivateProductAsync(int productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);

            if (product == null)
                return false;

            product.IsActive = false;

            try
            {
                _productRepository.Update(product);
                await _productRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to deactivate product.", ex);
            }
        }

        /// <summary>
        /// Activează un produs deactivat.
        /// </summary>
        public async Task<bool> ActivateProductAsync(int productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);

            if (product == null)
                return false;

            product.IsActive = true;

            try
            {
                _productRepository.Update(product);
                await _productRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to activate product.", ex);
            }
        }

        /// <summary>
        /// Actualizează cantitatea de stoc pentru un produs.
        /// </summary>
        public async Task<bool> UpdateStockAsync(int productId, int newStockQuantity)
        {
            var product = await _productRepository.GetByIdAsync(productId);

            if (product == null)
                return false;

            product.CurrentStock = newStockQuantity;

            try
            {
                _productRepository.Update(product);
                await _productRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to update stock.", ex);
            }
        }

        /// <summary>
        /// Validează datele produsului.
        /// </summary>
        private void ValidateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new ArgumentException("Product name is required.");

            if (product.CategoryId <= 0)
                throw new ArgumentException("Category ID is required.");

            if (product.SupplierId <= 0)
                throw new ArgumentException("Supplier ID is required.");

            if (product.UnitPrice < 0)
                throw new ArgumentException("Unit price cannot be negative.");

            if (product.CurrentStock < 0)
                throw new ArgumentException("Current stock cannot be negative.");

            if (product.SafetyStock < 0)
                throw new ArgumentException("Safety stock cannot be negative.");

            if (string.IsNullOrWhiteSpace(product.UnitOfMeasure))
                throw new ArgumentException("Unit of measure is required.");
        }

        /// <summary>
        /// Aplică sortarea query-ului.
        /// </summary>
        private IQueryable<Product> ApplySorting(IQueryable<Product> query, string sortBy, string sortOrder)
        {
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "ProductId";

            var isDescending = sortOrder?.ToLower() == "desc";

            return sortBy.ToLower() switch
            {
                "productname" => isDescending ? query.OrderByDescending(p => p.ProductName) : query.OrderBy(p => p.ProductName),
                "unitprice" => isDescending ? query.OrderByDescending(p => p.UnitPrice) : query.OrderBy(p => p.UnitPrice),
                "currentstock" => isDescending ? query.OrderByDescending(p => p.CurrentStock) : query.OrderBy(p => p.CurrentStock),
                "categoryname" => isDescending ? query.OrderByDescending(p => p.Category.CategoryName) : query.OrderBy(p => p.Category.CategoryName),
                "suppliername" => isDescending ? query.OrderByDescending(p => p.Supplier.SupplierName) : query.OrderBy(p => p.Supplier.SupplierName),
                _ => query.OrderBy(p => p.ProductId)
            };
        }
    }
}
