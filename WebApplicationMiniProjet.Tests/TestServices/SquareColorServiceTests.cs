using WebApplicationMiniProjet.Services.Services;

namespace WebApplicationMiniProjet.Tests.TestServices;

public class SquareColorServiceTests
{
    [Fact]
    public void CalculateSquareColors_ReturnsCorrectColors()
    {
        // Arrange
        var squareColorService = new SquareColorService();

        // Act
        var squareColors = squareColorService.CalculateSquareColors();

        // Assert
        Assert.Equal(50, squareColors.Count);

        // Vérifiez les couleurs attendues pour des nombres spécifiques
        Assert.Equal("green", squareColors[2]);  // 3
        Assert.Equal("blue", squareColors[9]);   // 10
        Assert.Equal("yellow", squareColors[14]); // 15
        Assert.Equal("blue", squareColors[49]);  // 50
    }
}
