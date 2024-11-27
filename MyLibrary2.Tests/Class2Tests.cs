namespace MyLibrary2.Tests;

public class Class2Tests
{
    private readonly Class2 _calculator = new();

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
}
