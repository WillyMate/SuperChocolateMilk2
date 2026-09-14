namespace SuperChocolateMilk.UnitTests;

using Xunit;
using SuperChocolateMilk.Core;

public class MilkRecipeCalculatorTests
{
    [Fact]
    public void Test1()
    {
        int milkVolumeM1 = 1000;
        string richness = "REGULAR";
        
        decimal result = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolumeM1,
            richness);
        
        Assert.Equal(100m, result);
    }
    [Theory]
    [InlineData(1000, "LIGHT", 75)]
    [InlineData(1000, "MEDIUM", 100)]
    [InlineData(1000, "EXTRA", 150)]
    [InlineData(1000, "ULTRA_CHOCO", 200)]
    [InlineData(0, "REGULAR", 0)]
    
    public void CalculateChocolateSyrup_VariousScenarios_ReturnsExpectedAmount(
        int milkVolume, string richness, decimal expectedSyrup)
    {
        // Act
        decimal actualResult = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);

        // Assert
        Assert.Equal(expectedSyrup, actualResult);
    }
}
