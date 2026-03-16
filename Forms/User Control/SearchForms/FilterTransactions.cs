using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Utils;
using Microsoft.EntityFrameworkCore;

namespace SmartStock.Forms.User_Control.SearchForms
{
    /// <summary>
    /// Passive View: Implementează IFilterControl și delegă logica de filtrare serviciului.
    /// Responsabil de colectarea datelor din controale și declanșarea filtrelor dinamice.
    /// 
    /// SOLID Principle - Single Responsibility:
    /// FilterTransactions se ocupa NUMAI de UI și colectare de criterii,
    /// logica de filtrare este în TransactionService.
    /// </summary>
    public partial class FilterTransactions : UserControl, IFilterControl
    {
        private TransactionService _transactionService;
        private UserService _userService;

        // Debounce timer for search (avoid excessive queries)
        private System.Windows.Forms.Timer _filterDebounceTimer;
        private const int DEBOUNCE_DELAY_MS = 100;

        public event Action FilterChanged;

        public FilterTransactions()
        {
            InitializeComponent();
            InitializeServices();
            InitializeDebounceTimer();
            LoadUI();
        }

        private void InitializeServices()
        {
            var transactionRepository = new GenericRepository<Transaction>(new SmartStockContext());
            var productRepository = new GenericRepository<Product>(new SmartStockContext());
            var userRepository = new GenericRepository<User>(new SmartStockContext());

            _transactionService = new TransactionService(transactionRepository, productRepository);
            _userService = new UserService(userRepository);
        }

        private void InitializeDebounceTimer()
        {
            _filterDebounceTimer = new System.Windows.Forms.Timer();
            _filterDebounceTimer.Interval = DEBOUNCE_DELAY_MS;
            _filterDebounceTimer.Tick += (s, e) =>
            {
                _filterDebounceTimer.Stop();
                OnFilterChanged();
            };
        }

        private void LoadUI()
        {
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            LoadTypesAsync();
            LoadUsersAsync();
            SetDefaultValues();

            // Wire up event handlers for dynamic filtering
            date_start.ValueChanged += (s, e) => OnFilterChanged();
            date_end.ValueChanged += (s, e) => OnFilterChanged();
            type_cb.SelectedIndexChanged += (s, e) => OnFilterChanged();
            user_cb.SelectedIndexChanged += (s, e) => OnFilterChanged();
            min_numeric.ValueChanged += (s, e) => OnFilterChanged();
            max_numeric.ValueChanged += (s, e) => OnFilterChanged();

            // Add tooltips for user guidance
            ToolTipHelp.AddToolTip(date_lbl, "Filter transactions by start date (inclusive).");
            ToolTipHelp.AddToolTip(type_lbl, "Filter transactions by type (All, Stock In, Stock Out, Adjustment).");
            ToolTipHelp.AddToolTip(user_lbl, "Filter transactions by user who performed the action.");
            ToolTipHelp.AddToolTip(range_lbl, "Filter transactions by quantity range (min-max).");

            tableLayoutPanel1.Padding = new Padding(0, 0, 45, 0);
            panel1.Padding = new Padding(0, 10, 0, 30);

            this.Refresh();
        }

        private void SetDefaultValues()
        {
            date_start.Value = DateTime.Now.AddMonths(-1);
            date_end.Value = DateTime.Now;
            min_numeric.Value = 0;
            max_numeric.Value = 0;
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        /// <summary>
        /// Încarcă tipurile de tranzacții disponibile.
        /// </summary>
        private async void LoadTypesAsync()
        {
            try
            {
                // Transaction types are predefined
                var types = new List<string>
                {
                    "All Types",      // Default
                    "Stock In",
                    "Stock Out",
                    "Adjustment"
                };

                type_cb.DataSource = types;
                type_cb.SelectedIndex = 0;  // Default: "All Types"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction types: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Încarcă utilizatorii din baza de date.
        /// </summary>
        private async void LoadUsersAsync()
        {
            try
            {
                var users = await _userService.GetAllActiveAsync();

                // Add "All Users" option at the beginning
                var userList = new List<User>
                {
                    new User { UserId = 0, Username = "All Users", IsActive = true }
                };
                userList.AddRange(users);

                user_cb.DataSource = userList;
                user_cb.DisplayMember = "Username";
                user_cb.ValueMember = "UserId";
                user_cb.SelectedIndex = 0;  // Default: "All Users"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Implementează IFilterControl: Obține datele filtrate.
        /// </summary>
        public object GetFilteredData()
        {
            var criteria = BuildFilterCriteria();
            return GetFilteredTransactionsAsync(criteria);
        }

        /// <summary>
        /// Construiește criteriile de filtrare din controale.
        /// Respectă SOLID: doar colectează date din UI, nu execută logică.
        /// </summary>
        private TransactionFilterCriteria BuildFilterCriteria()
        {
            var criteria = new TransactionFilterCriteria
            {
                PageSize = 0,    // No paging for DataGridView
                PageNumber = 1,
                SortBy = "Date",
                SortOrder = "desc"
            };

            // 1. FILTRU DATĂ (Start date)
            criteria.DateFrom = date_start.Value;

            // 2. FILTRU DATĂ (End date) - includul întreaga zi
            criteria.DateTo = date_end.Value;

            // 3. FILTRU TIP TRANZACȚIE
            if (type_cb.SelectedIndex > 0 && type_cb.SelectedItem is string selectedType)
            {
                criteria.Type = selectedType;
            }
            // If "All Types" is selected, Type remains null

            // 4. FILTRU UTILIZATOR
            if (user_cb.SelectedIndex > 0 && user_cb.SelectedValue is int userId && userId > 0)
            {
                criteria.UserId = userId;
            }
            // If "All Users" is selected, UserId remains null

            // 5. FILTRU CANTITATE (min-max)
            if (min_numeric.Value > 0)
                criteria.QuantityMin = (int)min_numeric.Value;
            if (max_numeric.Value > 0)
                criteria.QuantityMax = (int)max_numeric.Value;

            return criteria;
        }

        /// <summary>
        /// Obține tranzacțiile filtrate folosind serviciul.
        /// </summary>
        private async Task<List<Transaction>> GetFilteredTransactionsAsync(TransactionFilterCriteria criteria)
        {
            try
            {
                return await _transactionService.GetFilteredAsync(criteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading filtered transactions: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Transaction>();
            }
        }

        /// <summary>
        /// Declanșator pentru evenimentul FilterChanged - actualizează DataGridView dinamic.
        /// </summary>
        private void OnFilterChanged()
        {
            FilterChanged?.Invoke();
        }

        /// <summary>
        /// Încarcă datele default în grid. Apelată de SearchForm după ce s-a conectat la FilterChanged.
        /// </summary>
        public void LoadDefaultData()
        {
            OnFilterChanged();
        }

        /// <summary>
        /// Implementează IFilterControl: Resetează toate filtrele.
        /// </summary>
        public void ResetFilters()
        {
            date_start.Value = DateTime.Now.AddMonths(-1);
            date_end.Value = DateTime.Now;
            type_cb.SelectedIndex = 0;      // "All Types"
            user_cb.SelectedIndex = 0;      // "All Users"
            min_numeric.Value = 0;
            max_numeric.Value = 0;

            OnFilterChanged();
        }
    }
}

