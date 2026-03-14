# 🧪 TESTING GUIDE - ProductService

Ghid complet pentru crearea și rularea Unit Tests pentru ProductService.

---

## 📦 Prerequisite NuGet Packages

Adăugă aceste pachete în proiectul tău de test:

```xml
<!-- Packages.config sau .csproj -->
<PackageReference Include="MSTest.TestFramework" Version="3.0.2" />
<PackageReference Include="MSTest.TestAdapter" Version="3.0.2" />
<PackageReference Include="Moq" Version="4.18.4" />
```

Sau via Package Manager Console:
```powershell
Install-Package MSTest.TestFramework
Install-Package MSTest.TestAdapter
Install-Package Moq
```

---

## ✅ Setup Test Project

### 1. Creează Test Project
```powershell
dotnet new mstest -n SmartStock.Tests
cd SmartStock.Tests
dotnet add reference ../SmartStock/SmartStock.csproj
dotnet add package Moq
```

### 2. Structura Fișierelor
```
SmartStock.Tests/
├── Services/
│   └── ProductServiceTests.cs
├── Repositories/
│   └── GenericRepositoryTests.cs
└── UnitTest1.cs
```

---

## 🧪 Exemple de Tests

### Setup Bază (ProductServiceTests.cs)

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Models;

namespace SmartStock.Tests.Services
{
    [TestClass]
    public class ProductServiceTests
    {
        private Mock<IRepository<Product>> _mockRepository;
        private ProductService _productService;

        [TestInitialize]
        public void Setup()
        {
            _mockRepository = new Mock<IRepository<Product>>();
            _productService = new ProductService(_mockRepository.Object);
        }

        // Tests...
    }
}
```

---

## 🧬 Test Examples

### Test 1: Validare NullRepository

```csharp
[TestMethod]
public void Constructor_WithNullRepository_ThrowsArgumentNullException()
{
    // Arrange & Act & Assert
    Assert.ThrowsException<ArgumentNullException>(() =>
        new ProductService(null)
    );
}
```

**Executare**:
```powershell
dotnet test --filter "Constructor_WithNullRepository"
```

---

### Test 2: Adăugare Produs Valid

```csharp
[TestMethod]
public async Task AddProductAsync_WithValidProduct_ReturnsTrue()
{
    // Arrange
    var product = new Product
    {
        ProductName = "Test Product",
        CategoryId = 1,
        SupplierId = 1,
        UnitPrice = 10.50m,
        CurrentStock = 100,
        SafetyStock = 20,
        UnitOfMeasure = "pcs",
        IsActive = true
    };

    _mockRepository.Setup(r => r.SaveAsync())
        .ReturnsAsync(1);

    // Act
    var result = await _productService.AddProductAsync(product);

    // Assert
    Assert.IsTrue(result);
    _mockRepository.Verify(r => r.Add(product), Times.Once);
    _mockRepository.Verify(r => r.SaveAsync(), Times.Once);
}
```

**Execution**:
```powershell
dotnet test --filter "AddProductAsync_WithValidProduct"
```

---

### Test 3: Validare Produs Invalid

```csharp
[TestMethod]
[ExpectedException(typeof(ArgumentException))]
public async Task AddProductAsync_WithInvalidData_ThrowsArgumentException()
{
    var invalidProduct = new Product
    {
        ProductName = "", // Invalid!
        CategoryId = 1,
        SupplierId = 1,
        UnitPrice = 10,
        CurrentStock = 100,
        SafetyStock = 20,
        UnitOfMeasure = "pcs"
    };

    await _productService.AddProductAsync(invalidProduct);
}
```

---

### Test 4: Filtrare cu Criterii

```csharp
[TestMethod]
public async Task GetFilteredAsync_WithValidCriteria_ReturnsFiltered()
{
    // Arrange
    var criteria = new ProductFilterCriteria
    {
        CategoryId = 1,
        IsActive = true,
        PageSize = 10,
        PageNumber = 1
    };

    var mockProducts = new List<Product>
    {
        new Product { ProductId = 1, ProductName = "P1", CategoryId = 1, IsActive = true },
        new Product { ProductId = 2, ProductName = "P2", CategoryId = 1, IsActive = true }
    };

    _mockRepository.Setup(r => r.GetAll())
        .Returns(mockProducts.AsQueryable());

    // Act
    var result = await _productService.GetFilteredAsync(criteria);

    // Assert
    Assert.IsNotNull(result);
    Assert.IsTrue(result.Count > 0);
}
```

---

### Test 5: Actualizare Stoc

```csharp
[TestMethod]
public async Task UpdateStockAsync_WithValidData_UpdatesCorrectly()
{
    // Arrange
    int productId = 1;
    int newStock = 50;
    var product = new Product { ProductId = productId, CurrentStock = 100 };

    _mockRepository.Setup(r => r.GetByIdAsync(productId))
        .ReturnsAsync(product);
    _mockRepository.Setup(r => r.SaveAsync())
        .ReturnsAsync(1);

    // Act
    var result = await _productService.UpdateStockAsync(productId, newStock);

    // Assert
    Assert.IsTrue(result);
    Assert.AreEqual(50, product.CurrentStock);
    _mockRepository.Verify(r => r.Update(product), Times.Once);
}
```

---

### Test 6: Deactivare Produs

```csharp
[TestMethod]
public async Task DeactivateProductAsync_SetsIsActiveFalse()
{
    // Arrange
    var product = new Product { ProductId = 1, IsActive = true };

    _mockRepository.Setup(r => r.GetByIdAsync(1))
        .ReturnsAsync(product);
    _mockRepository.Setup(r => r.SaveAsync())
        .ReturnsAsync(1);

    // Act
    var result = await _productService.DeactivateProductAsync(1);

    // Assert
    Assert.IsTrue(result);
    Assert.IsFalse(product.IsActive);
    _mockRepository.Verify(r => r.Update(product), Times.Once);
}
```

---

## 🚀 Rulare Tests

### Rulare Toate
```powershell
dotnet test
```

### Rulare Specific Clasa
```powershell
dotnet test --filter "ProductServiceTests"
```

### Rulare Specific Metoda
```powershell
dotnet test --filter "AddProductAsync_WithValidProduct"
```

### Verbose Output
```powershell
dotnet test --verbosity detailed
```

### Coverage Report
```powershell
dotnet add package coverlet.collector
dotnet test /p:CollectCoverage=true
```

---

## 📊 Test Coverage Targets

| Component | Min Coverage |
|-----------|--------------|
| ProductService | 90% |
| GenericRepository | 85% |
| ProductFilterCriteria | 100% |

---

## 🔍 Mock Strategies

### Strategy 1: Minimal Mock
```csharp
// Returneaza valori default
_mockRepository.Setup(r => r.SaveAsync()).ReturnsAsync(1);
```

### Strategy 2: Complex Mock
```csharp
// Simulează comportament real
_mockRepository.Setup(r => r.GetAll())
    .Returns(products.AsQueryable());
```

### Strategy 3: Verify Interactions
```csharp
// Verifică că metodele au fost apelate corect
_mockRepository.Verify(r => r.Add(It.IsAny<Product>()), Times.Once);
_mockRepository.Verify(r => r.SaveAsync(), Times.Once);
```

---

## ⚠️ Common Pitfalls

### ❌ Testare cu Database Real
```csharp
// BAD - Încer baza de date reală
using (var db = new SmartStockContext())
{
    var product = db.Products.First();
}
```

### ✅ Testare cu Mock
```csharp
// GOOD - Mock repository
var mockRepo = new Mock<IRepository<Product>>();
var service = new ProductService(mockRepo.Object);
```

---

## 📝 Test Template

```csharp
[TestMethod]
public async Task MethodName_WithScenario_ExpectedResult()
{
    // Arrange - Setup
    var mockRepository = new Mock<IRepository<Product>>();
    var service = new ProductService(mockRepository.Object);
    
    var testData = new Product { /* ... */ };
    mockRepository.Setup(r => r.GetByIdAsync(It.IsAny<object>()))
        .ReturnsAsync(testData);

    // Act - Execute
    var result = await service.SomeMethodAsync();

    // Assert - Verify
    Assert.IsNotNull(result);
    mockRepository.Verify(r => r.SaveAsync(), Times.Once);
}
```

---

## 🎯 Best Practices

1. ✅ **One Assertion Per Test** - Fiecare test verifică o singură chestie
2. ✅ **AAA Pattern** - Arrange, Act, Assert
3. ✅ **Descriptive Names** - `AddProductAsync_WithValidData_ReturnsTrue`
4. ✅ **Use Mock** - Nu folosiți baza de date reală
5. ✅ **Test Edge Cases** - null, invalid values, boundaries
6. ✅ **Fast Tests** - Tests să ruleze în <1 sec
7. ✅ **Isolate Dependencies** - Mock tot ce nu testezi

---

## 🔗 Resurse

- [Microsoft MSTest](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting)
- [Moq Documentation](https://github.com/moq/moq4)
- [Unit Testing Best Practices](https://docs.microsoft.com/en-us/dotnet/core/testing/)

---

**Ready for Testing**: 🧪 ✅
