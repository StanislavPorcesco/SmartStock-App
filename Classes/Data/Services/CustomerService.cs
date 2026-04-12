using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Serviciu pentru logica de business a entității Customer.
    /// Conține toate query-urile LINQ, calculele și logica de filtrare.
    /// </summary>
    public class CustomerService
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IRepository<Sale> _saleRepository;

        public CustomerService(IRepository<Customer> customerRepository, IRepository<Sale> saleRepository = null)
        {
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
            _saleRepository = saleRepository;
        }

        /// <summary>
        /// Obține toți clienții activi.
        /// </summary>
        public async Task<List<Customer>> GetAllActiveAsync()
        {
            return await _customerRepository
                .GetAll()
                .Where(c => c.IsActive)
                .OrderBy(c => c.FullName)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține un client cu comenzile sale.
        /// </summary>
        public async Task<Customer> GetWithSalesAsync(int customerId)
        {
            return await _customerRepository
                .GetAll()
                .Where(c => c.CustomerId == customerId)
                .Include(c => c.Sales)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        /// <summary>
        /// Filtrează clienții conform criteriilor furnizate.
        /// IMPORTANT: Include Sales pentru calculele de vânzări și valoare totală.
        /// </summary>
        public async Task<List<Customer>> GetFilteredAsync(CustomerFilterCriteria criteria)
        {
            if (criteria == null)
                throw new ArgumentNullException(nameof(criteria));

            IQueryable<Customer> query = _customerRepository.GetAll()
                .Include(c => c.Sales);  // ✅ IMPORTANT: Eager load Sales

            // Filtru după stare
            if (criteria.IsActive.HasValue)
            {
                query = query.Where(c => c.IsActive == criteria.IsActive.Value);
            }
            else
            {
                query = query.Where(c => c.IsActive);
            }

            // Căutare text (în nume, email, telefon)
            if (!string.IsNullOrWhiteSpace(criteria.SearchText))
            {
                var searchLower = criteria.SearchText.ToLower();
                query = query.Where(c => c.FullName.ToLower().Contains(searchLower) || 
                                         c.Email.ToLower().Contains(searchLower) ||
                                         c.Phone.Contains(searchLower));
            }

            // Filtru după oraș
            if (!string.IsNullOrWhiteSpace(criteria.City))
            {
                var cityLower = criteria.City.ToLower();
                query = query.Where(c => c.City.ToLower().Contains(cityLower));
            }

            // Filtru după dată de înregistrare (de la)
            if (criteria.RegisteredFrom.HasValue)
            {
                query = query.Where(c => c.RegistrationDate >= criteria.RegisteredFrom.Value);
            }

            // Filtru după dată de înregistrare (până la)
            if (criteria.RegisteredTo.HasValue)
            {
                var endDate = criteria.RegisteredTo.Value.AddDays(1); // Include the entire day
                query = query.Where(c => c.RegistrationDate < endDate);
            }

            // POST-PROCESSING FILTERS (after materialization due to complexity with Sales calculations)
            var results = await query.AsNoTracking().ToListAsync();

            // Filtru după numărul de vânzări (min-max)
            if (criteria.MinSalesCount.HasValue || criteria.MaxSalesCount.HasValue)
            {
                var minCount = criteria.MinSalesCount ?? 0;
                var maxCount = criteria.MaxSalesCount ?? int.MaxValue;

                results = results
                    .Where(c => (c.Sales?.Count ?? 0) >= minCount && (c.Sales?.Count ?? 0) <= maxCount)
                    .ToList();
            }

            // Filtru după valoare totală cheltuită (min-max)
            if (criteria.MinTotalSpent.HasValue || criteria.MaxTotalSpent.HasValue)
            {
                var minSpent = criteria.MinTotalSpent ?? 0;
                var maxSpent = criteria.MaxTotalSpent ?? decimal.MaxValue;

                results = results
                    .Where(c => 
                    {
                        var totalSpent = (decimal)(c.Sales?.Sum(s => (double?)s.TotalAmount) ?? 0.0);
                        return totalSpent >= minSpent && totalSpent <= maxSpent;
                    })
                    .ToList();
            }

            // Sortare
            results = ApplySortingLocal(results, criteria.SortBy, criteria.SortOrder);

            // Paginare
            if (criteria.PageSize > 0)
            {
                results = results
                    .Skip((criteria.PageNumber - 1) * criteria.PageSize)
                    .Take(criteria.PageSize)
                    .ToList();
            }

            return results;
        }

        /// <summary>
        /// Obține statistici pe clienți (count comenzi pe client).
        /// </summary>
        public async Task<List<dynamic>> GetCustomerStatsAsync()
        {
            return await _customerRepository
                .GetAll()
                .Where(c => c.IsActive)
                .Include(c => c.Sales)
                .AsNoTracking()
                .Select(c => new
                {
                    CustomerId = c.CustomerId,
                    FullName = c.FullName,
                    City = c.City,
                    Email = c.Email,
                    RegistrationDate = c.RegistrationDate,
                    SalesCount = c.Sales.Count,
                    TotalPurchaseValue = c.Sales.Sum(s => (double?)s.TotalAmount) ?? 0.0
                })
                .Cast<dynamic>()
                .ToListAsync();
        }

        /// <summary>
        /// Obține comenzile dintr-un client.
        /// </summary>
        public async Task<List<Sale>> GetCustomerSalesAsync(int customerId)
        {
            if (_saleRepository == null)
                throw new InvalidOperationException("SaleRepository not provided");

            return await _saleRepository
                .GetAll()
                .Where(s => s.CustomerId == customerId)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Obține valoarea totală de achiziții pentru un client.
        /// </summary>
        public async Task<decimal> GetTotalPurchaseValueAsync(int customerId)
        {
            if (_saleRepository == null)
                throw new InvalidOperationException("SaleRepository not provided");

            var total = await _saleRepository
                .GetAll()
                .Where(s => s.CustomerId == customerId)
                .SumAsync(s => (double?)s.TotalAmount);

            return (decimal)(total ?? 0.0);
        }

        /// <summary>
        /// Verifică dacă un nume de client există deja (case-insensitive).
        /// </summary>
        public async Task<bool> CustomerNameExistsAsync(string fullName, int? excludeId = null)
        {
            if (string.IsNullOrWhiteSpace(fullName))
                return false;

            var nameLower = fullName.ToLower();
            var query = _customerRepository
                .GetAll()
                .Where(c => c.FullName.ToLower() == nameLower);

            if (excludeId.HasValue)
                query = query.Where(c => c.CustomerId != excludeId.Value);

            return await query.AnyAsync();
        }

        /// <summary>
        /// Validează un email (format de bază).
        /// </summary>
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true; // Email optional

            return email.Contains("@") && email.Contains(".");
        }

        /// <summary>
        /// Adaugă un nou client.
        /// </summary>
        public async Task<bool> AddCustomerAsync(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            ValidateCustomer(customer);

            // Verifică duplicate
            if (await CustomerNameExistsAsync(customer.FullName))
                throw new InvalidOperationException($"Customer '{customer.FullName}' already exists.");

            try
            {
                // Set registration date to now if not provided
                if (customer.RegistrationDate == default)
                    customer.RegistrationDate = DateTime.Now;

                _customerRepository.Add(customer);
                await _customerRepository.SaveAsync();
                ActivityLogger.LogUserAction("ADD", "Customer", customer.FullName, customer.CustomerId);
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to add customer.", ex);
            }
        }

        /// <summary>
        /// Actualizează un client existent.
        /// </summary>
        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException(nameof(customer));

            ValidateCustomer(customer);

            // Verifică duplicate (excluzând ID-ul curent)
            if (await CustomerNameExistsAsync(customer.FullName, customer.CustomerId))
                throw new InvalidOperationException($"Another customer with name '{customer.FullName}' already exists.");

            try
            {
                _customerRepository.Update(customer);
                await _customerRepository.SaveAsync();
                ActivityLogger.LogUserAction("MODIFY", "Customer", customer.FullName, customer.CustomerId);
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to update customer.", ex);
            }
        }

        /// <summary>
        /// Deactivează un client (soft delete).
        /// </summary>
        public async Task<bool> DeactivateCustomerAsync(int customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);

            if (customer == null)
                return false;

            customer.IsActive = false;

            try
            {
                _customerRepository.Update(customer);
                await _customerRepository.SaveAsync();
                ActivityLogger.LogUserAction("ARCHIVE", "Customer", customer.FullName, customer.CustomerId);
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to deactivate customer.", ex);
            }
        }

        /// <summary>
        /// Activează un client deactivat.
        /// </summary>
        public async Task<bool> ActivateCustomerAsync(int customerId)
        {
            var customer = await _customerRepository.GetByIdAsync(customerId);

            if (customer == null)
                return false;

            customer.IsActive = true;

            try
            {
                _customerRepository.Update(customer);
                await _customerRepository.SaveAsync();
                ActivityLogger.LogUserAction("RESTORE", "Customer", customer.FullName, customer.CustomerId);
                return true;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to activate customer.", ex);
            }
        }

        /// <summary>
        /// Obține clientul după ID.
        /// </summary>
        public async Task<Customer> GetByIdAsync(int customerId)
        {
            return await _customerRepository.GetByIdAsync(customerId);
        }

        /// <summary>
        /// Obține numărul de clienți activi.
        /// </summary>
        public async Task<int> GetActiveCustomerCountAsync()
        {
            return await _customerRepository
                .GetAll()
                .Where(c => c.IsActive)
                .CountAsync();
        }

        /// <summary>
        /// Obține clienții înregistrați într-o anumită perioadă.
        /// </summary>
        public async Task<List<Customer>> GetCustomersByRegistrationPeriodAsync(DateTime fromDate, DateTime toDate)
        {
            return await _customerRepository
                .GetAll()
                .Where(c => c.IsActive && c.RegistrationDate >= fromDate && c.RegistrationDate <= toDate)
                .OrderBy(c => c.FullName)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Validează datele clientului.
        /// </summary>
        private void ValidateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
                throw new ArgumentException("Customer full name is required.");

            if (customer.FullName.Length > 150)
                throw new ArgumentException("Customer full name cannot exceed 150 characters.");

            if (!string.IsNullOrWhiteSpace(customer.Email) && !IsValidEmail(customer.Email))
                throw new ArgumentException("Invalid email format.");

            if (!string.IsNullOrWhiteSpace(customer.Phone) && customer.Phone.Length > 20)
                throw new ArgumentException("Phone number cannot exceed 20 characters.");

            if (!string.IsNullOrWhiteSpace(customer.City) && customer.City.Length > 100)
                throw new ArgumentException("City cannot exceed 100 characters.");
        }

        /// <summary>
        /// Aplică sortarea query-ului.
        /// </summary>
        private IQueryable<Customer> ApplySorting(IQueryable<Customer> query, string sortBy, string sortOrder)
        {
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "FullName";

            var isDescending = sortOrder?.ToLower() == "desc";

            return sortBy.ToLower() switch
            {
                "fullname" => isDescending 
                    ? query.OrderByDescending(c => c.FullName) 
                    : query.OrderBy(c => c.FullName),
                "customerid" => isDescending 
                    ? query.OrderByDescending(c => c.CustomerId) 
                    : query.OrderBy(c => c.CustomerId),
                "registrationdate" => isDescending 
                    ? query.OrderByDescending(c => c.RegistrationDate) 
                    : query.OrderBy(c => c.RegistrationDate),
                "city" => isDescending 
                    ? query.OrderByDescending(c => c.City) 
                    : query.OrderBy(c => c.City),
                _ => query.OrderBy(c => c.FullName)
            };
        }

        /// <summary>
        /// Aplică sortarea pentru o listă în memorie (după materialization).
        /// Folosit pentru post-processing filtering complex.
        /// </summary>
        private List<Customer> ApplySortingLocal(List<Customer> items, string sortBy, string sortOrder)
        {
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "FullName";

            var isDescending = sortOrder?.ToLower() == "desc";

            return sortBy.ToLower() switch
            {
                "fullname" => isDescending 
                    ? items.OrderByDescending(c => c.FullName).ToList() 
                    : items.OrderBy(c => c.FullName).ToList(),
                "customerid" => isDescending 
                    ? items.OrderByDescending(c => c.CustomerId).ToList() 
                    : items.OrderBy(c => c.CustomerId).ToList(),
                "registrationdate" => isDescending 
                    ? items.OrderByDescending(c => c.RegistrationDate).ToList() 
                    : items.OrderBy(c => c.RegistrationDate).ToList(),
                "city" => isDescending 
                    ? items.OrderByDescending(c => c.City).ToList() 
                    : items.OrderBy(c => c.City).ToList(),
                _ => items.OrderBy(c => c.FullName).ToList()
            };
        }
    }
}
