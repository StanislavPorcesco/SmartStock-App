using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Serviciu pentru logica de business a entității Transaction.
    /// Conține toate query-urile LINQ, calculele și logica de filtrare.
    /// Gestionează istoric de stoc și actualizări de stoc pentru produse.
    /// </summary>
    public class TransactionService
    {
        private readonly IRepository<Transaction> _transactionRepository;
        private readonly IRepository<Product> _productRepository;

        public TransactionService(
            IRepository<Transaction> transactionRepository,
            IRepository<Product> productRepository = null)
        {
            _transactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
            _productRepository = productRepository;
        }

        /// <summary>
        /// Obține toate tranzacțiile de la cel mai recent.
        /// </summary>
        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _transactionRepository
                .GetAll()
                .OrderByDescending(t => t.Date)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține o tranzacție cu produs și utilizator.
        /// </summary>
        public async Task<Transaction> GetWithDetailsAsync(int transactionId)
        {
            return await _transactionRepository
                .GetAll()
                .Where(t => t.TransactionId == transactionId)
                .Include(t => t.Product)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Filtrează tranzacțiile conform criteriilor furnizate.
        /// IMPORTANT: Include Product pentru a evita Lazy Loading issues.
        /// </summary>
        public async Task<List<Transaction>> GetFilteredAsync(TransactionFilterCriteria criteria)
        {
            if (criteria == null)
                throw new ArgumentNullException(nameof(criteria));

            IQueryable<Transaction> query = _transactionRepository.GetAll()
                .Include(t => t.Product);  // ✅ IMPORTANT: Eager load Product

            // Filtru după produs
            if (criteria.ProductId.HasValue)
            {
                query = query.Where(t => t.ProductId == criteria.ProductId.Value);
            }

            // Filtru după utilizator
            if (criteria.UserId.HasValue)
            {
                query = query.Where(t => t.UserId == criteria.UserId.Value);
            }

            // Filtru după entitate (Supplier/Customer)
            if (criteria.EntityId.HasValue)
            {
                query = query.Where(t => t.EntityId == criteria.EntityId.Value);
            }

            // Filtru după tip de tranzacție
            if (!string.IsNullOrWhiteSpace(criteria.Type))
            {
                var typeLower = criteria.Type.ToLower();
                query = query.Where(t => t.Type.ToLower() == typeLower);
            }

            // Filtru după dată (de la)
            if (criteria.DateFrom.HasValue)
            {
                query = query.Where(t => t.Date >= criteria.DateFrom.Value);
            }

            // Filtru după dată (până la)
            if (criteria.DateTo.HasValue)
            {
                var endDate = criteria.DateTo.Value.AddDays(1); // Include entire day
                query = query.Where(t => t.Date < endDate);
            }

            // Filtru după cantitate (minim)
            if (criteria.QuantityMin.HasValue)
            {
                query = query.Where(t => t.Quantity >= criteria.QuantityMin.Value);
            }

            // Filtru după cantitate (maxim)
            if (criteria.QuantityMax.HasValue)
            {
                query = query.Where(t => t.Quantity <= criteria.QuantityMax.Value);
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
        /// Obține istoric de tranzacții pentru un produs.
        /// </summary>
        public async Task<List<Transaction>> GetProductHistoryAsync(int productId)
        {
            return await _transactionRepository
                .GetAll()
                .Where(t => t.ProductId == productId)
                .OrderByDescending(t => t.Date)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține toate ajustările de stoc.
        /// </summary>
        public async Task<List<Transaction>> GetAdjustmentReportAsync()
        {
            return await _transactionRepository
                .GetAll()
                .Where(t => t.Type == "Adjustment")
                .Include(t => t.Product)
                .OrderByDescending(t => t.Date)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține tranzacții Stock In (reaprovizionări).
        /// </summary>
        public async Task<List<Transaction>> GetStockInTransactionsAsync(int productId)
        {
            return await _transactionRepository
                .GetAll()
                .Where(t => t.ProductId == productId && t.Type == "Stock In")
                .OrderByDescending(t => t.Date)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține tranzacții Stock Out (vânzări/ieșiri).
        /// </summary>
        public async Task<List<Transaction>> GetStockOutTransactionsAsync(int productId)
        {
            return await _transactionRepository
                .GetAll()
                .Where(t => t.ProductId == productId && t.Type == "Stock Out")
                .OrderByDescending(t => t.Date)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține statistici de tranzacții (totale intrări, ieșiri, ajustări).
        /// </summary>
        public async Task<dynamic> GetTransactionStatsAsync(DateTime fromDate, DateTime toDate)
        {
            var stats = await _transactionRepository
                .GetAll()
                .Where(t => t.Date >= fromDate && t.Date < toDate.AddDays(1))
                .GroupBy(t => 1)
                .Select(g => new
                {
                    TotalTransactions = g.Count(),
                    TotalQuantityIn = g.Where(t => t.Type == "Stock In").Sum(t => (long?)t.Quantity) ?? 0L,
                    TotalQuantityOut = g.Where(t => t.Type == "Stock Out").Sum(t => (long?)t.Quantity) ?? 0L,
                    AdjustmentCount = g.Count(t => t.Type == "Adjustment"),
                    StockInCount = g.Count(t => t.Type == "Stock In"),
                    StockOutCount = g.Count(t => t.Type == "Stock Out")
                })
                .FirstOrDefaultAsync();

            return stats ?? new { TotalTransactions = 0, TotalQuantityIn = 0L, TotalQuantityOut = 0L, AdjustmentCount = 0, StockInCount = 0, StockOutCount = 0 };
        }

        /// <summary>
        /// Adaugă o nouă tranzacție și actualizează stocul produsului.
        /// </summary>
        public async Task<bool> AddTransactionAsync(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            ValidateTransaction(transaction);

            if (_productRepository == null)
                throw new InvalidOperationException("ProductRepository is required for this operation.");

            try
            {
                // Get product
                var product = await _productRepository.GetByIdAsync(transaction.ProductId);
                if (product == null)
                    throw new InvalidOperationException($"Product {transaction.ProductId} not found.");

                // Validate stock for outgoing transactions
                if ((transaction.Type == "Stock Out" || transaction.Type == "Adjustment") && product.CurrentStock < transaction.Quantity)
                    throw new InvalidOperationException($"Insufficient stock! Current: {product.CurrentStock}, Requested: {transaction.Quantity}");

                // Add transaction
                _transactionRepository.Add(transaction);
                await _transactionRepository.SaveAsync();

                // Update product stock
                if (transaction.Type == "Stock In")
                    product.CurrentStock += transaction.Quantity;
                else if (transaction.Type == "Stock Out" || transaction.Type == "Adjustment")
                    product.CurrentStock -= transaction.Quantity;

                _productRepository.Update(product);
                await _productRepository.SaveAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to register transaction.", ex);
            }
        }

        /// <summary>
        /// Șterge o tranzacție și REVOACĂ ajustarea stocului.
        /// ATENȚIE: Folosește cu precauție!
        /// </summary>
        public async Task<bool> DeleteTransactionAsync(int transactionId)
        {
            var transaction = await _transactionRepository.GetByIdAsync(transactionId);
            if (transaction == null)
                return false;

            if (_productRepository == null)
                throw new InvalidOperationException("ProductRepository is required for this operation.");

            try
            {
                // Get product
                var product = await _productRepository.GetByIdAsync(transaction.ProductId);
                if (product == null)
                    throw new InvalidOperationException($"Product {transaction.ProductId} not found.");

                // Revert stock changes
                if (transaction.Type == "Stock In")
                    product.CurrentStock -= transaction.Quantity;
                else if (transaction.Type == "Stock Out" || transaction.Type == "Adjustment")
                    product.CurrentStock += transaction.Quantity;

                _productRepository.Update(product);
                await _productRepository.SaveAsync();

                // Delete transaction
                _transactionRepository.Delete(transaction);
                await _transactionRepository.SaveAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to delete transaction.", ex);
            }
        }

        /// <summary>
        /// Obține tranzacția după ID.
        /// </summary>
        public async Task<Transaction> GetByIdAsync(int transactionId)
        {
            return await _transactionRepository.GetByIdAsync(transactionId);
        }

        /// <summary>
        /// Obține numărul total de tranzacții.
        /// </summary>
        public async Task<int> GetTransactionCountAsync()
        {
            return await _transactionRepository
                .GetAll()
                .CountAsync();
        }

        /// <summary>
        /// Validează datele tranzacției.
        /// </summary>
        private void ValidateTransaction(Transaction transaction)
        {
            if (transaction.ProductId <= 0)
                throw new ArgumentException("Valid Product ID is required.");

            if (transaction.UserId <= 0)
                throw new ArgumentException("Valid User ID is required.");

            if (transaction.Quantity <= 0)
                throw new ArgumentException("Quantity must be greater than 0.");

            if (string.IsNullOrWhiteSpace(transaction.Type))
                throw new ArgumentException("Transaction Type is required.");

            var validTypes = new[] { "Stock In", "Stock Out", "Adjustment" };
            if (!validTypes.Contains(transaction.Type))
                throw new ArgumentException($"Invalid transaction type. Must be one of: {string.Join(", ", validTypes)}");
        }

        /// <summary>
        /// Aplică sortarea query-ului.
        /// </summary>
        private IQueryable<Transaction> ApplySorting(IQueryable<Transaction> query, string sortBy, string sortOrder)
        {
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Date";

            var isDescending = sortOrder?.ToLower() == "desc";

            return sortBy.ToLower() switch
            {
                "date" => isDescending
                    ? query.OrderByDescending(t => t.Date)
                    : query.OrderBy(t => t.Date),
                "transactionid" => isDescending
                    ? query.OrderByDescending(t => t.TransactionId)
                    : query.OrderBy(t => t.TransactionId),
                "type" => isDescending
                    ? query.OrderByDescending(t => t.Type)
                    : query.OrderBy(t => t.Type),
                "quantity" => isDescending
                    ? query.OrderByDescending(t => t.Quantity)
                    : query.OrderBy(t => t.Quantity),
                "productid" => isDescending
                    ? query.OrderByDescending(t => t.ProductId)
                    : query.OrderBy(t => t.ProductId),
                _ => query.OrderByDescending(t => t.Date)
            };
        }
    }
}
