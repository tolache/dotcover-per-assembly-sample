namespace MyLibrary1.Tests;

public class Class1Tests
{
    private readonly Class1 _calculator = new();

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        int a = 5, b = 3;
    
        // Act
        int result = _calculator.Add(a, b);
    
        // Assert
        Assert.Equal(8, result);
    }
    
    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        int a = 5, b = 3;
        int result = _calculator.Subtract(a, b);
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        int a = 5, b = 3;
        int result = _calculator.Multiply(a, b);
        Assert.Equal(15, result);
    }
    
    [Fact]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        int a = 6, b = 2;
        double result = _calculator.Divide(a, b);
        Assert.Equal(3, result, 2);  // Precision: 2 decimal places
    }
    
    [Fact]
    public void Divide_ByZero_ShouldThrowArgumentException()
    {
        int a = 5, b = 0;
    
        var exception = Assert.Throws<ArgumentException>(() => _calculator.Divide(a, b));
        Assert.Equal("Division by zero is not allowed.", exception.Message);
    }
}
