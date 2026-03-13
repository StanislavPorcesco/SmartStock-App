# FilterProducts Integration Guide

## Overview
The `FilterProducts` UserControl provides a comprehensive filtering system for products with cumulative AND logic. It includes filters for:
- Category selection
- Supplier name search
- Safety stock threshold
- Dead stock detection
- Price range
- Top sellers

## Component Structure

### UI Elements
- **Category ComboBox**: Populated from database, includes "All Categories" option
- **Supplier TextBox**: Text search for supplier names
- **Safety Limit CheckBox**: Filters products below safety stock threshold
- **Dead Stock TextBox**: Numeric input for days without transactions
- **Price Range**: Min and Max NumericUpDown controls
- **Top Sellers CheckBox**: Filters top 20 selling products
- **Apply Filters Button**: Executes filtering logic
- **Reset Filters Button**: Clears all filter inputs

### Events
- **OnFilterApplied**: `Action<List<Product>>` event fired when Apply button is clicked
  - Passes the filtered product list to subscribers

## Integration Steps

### Step 1: Add FilterProducts to SearchForm Designer

In your `SearchForm.Designer.cs`, add the FilterProducts UserControl:

```csharp
private FilterProducts filterProducts;

// In InitializeComponent:
filterProducts = new FilterProducts();
filterProducts.Dock = DockStyle.Left; // or your preferred layout
filterProducts.Size = new Size(529, 582);
// Add to a panel or directly to the form
panel_filters.Controls.Add(filterProducts);
```

### Step 2: Subscribe to OnFilterApplied Event

In your `SearchForm.cs` constructor or initialization method:

```csharp
public partial class SearchForm : Form
{
    private DataGridView main_dgv;
    private FilterProducts filterProducts;

    public SearchForm()
    {
        InitializeComponent();
        SetupFilters();
    }

    private void SetupFilters()
    {
        // Subscribe to the filter applied event
        filterProducts.OnFilterApplied += (filteredProducts) =>
        {
            // Update the DataGridView with filtered results
            main_dgv.DataSource = filteredProducts;
            
            // Optional: Format columns
            FormatDataGridColumns();
        };
    }

    private void FormatDataGridColumns()
    {
        if (main_dgv.Columns.Count > 0)
        {
            main_dgv.Columns["ProductName"].HeaderText = "Product Name";
            main_dgv.Columns["UnitPrice"].HeaderText = "Price";
            main_dgv.Columns["CurrentStock"].HeaderText = "Stock";
            main_dgv.Columns["SafetyStock"].HeaderText = "Safety Level";
            
            // Format price column
            main_dgv.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
        }
    }
}
```

### Step 3: Handle Initial Load

Load all products initially or show an empty DataGridView:

```csharp
private void SearchForm_Load(object sender, EventArgs e)
{
    // Option 1: Load all products initially
    LoadAllProducts();

    // Option 2: Wait for user to apply filters
    // main_dgv.DataSource = null;
}

private void LoadAllProducts()
{
    try
    {
        using (var db = new SmartStockContext())
        {
            var allProducts = db.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .ToList();

            main_dgv.DataSource = allProducts;
            FormatDataGridColumns();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error loading products: {ex.Message}", "Error", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
```

## Filtering Logic Details

### Cumulative Filters (AND Logic)
All active filters are combined with AND logic, meaning:
- Products must be in the selected category **AND**
- Product name must contain the supplier text **AND**
- Stock must be below safety level (if checked) **AND**
- Price must be within range **AND**
- Other active filters...

### Filter Examples

**Example 1: Electronics under safety stock with price between $10-$50**
```
Category: Electronics
Under Safety Limit: Checked
Price Min: 10
Price Max: 50
Result: Only Electronics products with stock < safety level AND price between $10-$50
```

**Example 2: Top sellers in specific category**
```
Category: Electronics
Top Sellers: Checked
Result: Top 20 best-selling products in the Electronics category
```

### Dead Stock Calculation
Products are considered "dead stock" if they have no transactions (sales or purchases) in the specified number of days.

### Top Sellers Calculation
Top sellers are determined by transaction volume (quantity sold) in the last 30 days, filtering by "Stock Out" transactions and showing the top 20.

## Event Handling Best Practices

### With Error Handling
```csharp
filterProducts.OnFilterApplied += (filteredProducts) =>
{
    try
    {
        if (filteredProducts == null || filteredProducts.Count == 0)
        {
            main_dgv.DataSource = null;
            MessageBox.Show("No products match the selected filters.", "No Results", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            main_dgv.DataSource = filteredProducts;
            status_lbl.Text = $"Displaying {filteredProducts.Count} products";
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error updating results: {ex.Message}", "Error", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
};
```

### With Loading Indicator
```csharp
filterProducts.OnFilterApplied += (filteredProducts) =>
{
    // Show loading indicator
    this.Cursor = Cursors.WaitCursor;
    Application.DoEvents();

    try
    {
        main_dgv.DataSource = filteredProducts;
        FormatDataGridColumns();
    }
    finally
    {
        this.Cursor = Cursors.Default;
    }
};
```

## Complete Integration Example

```csharp
public partial class SearchForm : Form
{
    private DataGridView main_dgv;
    private FilterProducts filterProducts;
    private Label status_lbl;

    public SearchForm()
    {
        InitializeComponent();
        SetupUI();
        SetupFilters();
        LoadInitialData();
    }

    private void SetupUI()
    {
        // Initialize FilterProducts control
        filterProducts = new FilterProducts();
        filterProducts.Dock = DockStyle.Left;
        filterProducts.Width = 530;
        this.Controls.Add(filterProducts);

        // Setup DataGridView
        main_dgv = new DataGridView();
        main_dgv.Dock = DockStyle.Fill;
        main_dgv.ReadOnly = true;
        main_dgv.AllowUserToAddRows = false;
        main_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.Controls.Add(main_dgv);
    }

    private void SetupFilters()
    {
        filterProducts.OnFilterApplied += HandleFiltersApplied;
    }

    private void HandleFiltersApplied(List<Product> filteredProducts)
    {
        try
        {
            main_dgv.DataSource = filteredProducts.Select(p => new
            {
                p.ProductId,
                p.ProductName,
                Category = p.Category?.CategoryName,
                Supplier = p.Supplier?.SupplierName,
                p.UnitPrice,
                p.CurrentStock,
                p.SafetyStock,
                Stock_Status = p.IsUnderSafetyLimit ? "⚠ Low" : "✓ OK"
            }).ToList();

            FormatDataGridColumns();
            status_lbl.Text = $"Displaying {filteredProducts.Count} of {GetTotalProductCount()} products";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadInitialData()
    {
        try
        {
            using (var db = new SmartStockContext())
            {
                var allProducts = db.Products
                    .AsNoTracking()
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .ToList();

                main_dgv.DataSource = allProducts.Select(p => new
                {
                    p.ProductId,
                    p.ProductName,
                    Category = p.Category?.CategoryName,
                    Supplier = p.Supplier?.SupplierName,
                    p.UnitPrice,
                    p.CurrentStock,
                    p.SafetyStock,
                    Stock_Status = p.IsUnderSafetyLimit ? "⚠ Low" : "✓ OK"
                }).ToList();

                FormatDataGridColumns();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading products: {ex.Message}", "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private int GetTotalProductCount()
    {
        using (var db = new SmartStockContext())
        {
            return db.Products.Count();
        }
    }

    private void FormatDataGridColumns()
    {
        if (main_dgv.Columns.Count > 0)
        {
            main_dgv.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
            main_dgv.AutoResizeColumns();
        }
    }
}
```

## Performance Considerations

1. **AsNoTracking()**: Used for read-only operations to improve performance
2. **Indexes**: Ensure database columns used in filters have appropriate indexes
3. **Batch Loading**: Category and Supplier data loaded once during initialization
4. **Lazy Loading**: Transaction data loaded only when "Dead Stock" or "Top Sellers" filters are active

## Troubleshooting

### Issue: Filters not applying
**Solution**: Ensure `OnFilterApplied` event is properly subscribed to in the parent form.

### Issue: Slow filtering performance
**Solution**: Add database indexes on frequently filtered columns (CategoryId, UnitPrice, CurrentStock, SafetyStock).

### Issue: Dead stock filter not working
**Solution**: Verify Transaction table has Date column and products have transactions recorded.

### Issue: Category dropdown empty
**Solution**: Ensure Categories table has data in the database and SmartStockContext is properly configured.
