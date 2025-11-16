using FluentAssertions;
using Src.Quest03;
using Xunit;

namespace Test;

public class Quest03Test
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest03/testData1.txt";
    private readonly string _testData2 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest03/testData2.txt";
    private readonly string _testData3 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest03/testData3.txt";

    [Fact]
    public void ReadNumbersTest()
    {
        // Arrange
        var expected = new[] { 10, 5, 1, 10, 3, 8, 5, 2, 2 };

        // Act
        var result = SolutionP1.ReadNumbers(_testData1);
        
        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Calculate1Test()
    {
        // Arrange
        var expected = 29;

        // Act
        var result = SolutionP1.Calculate(_testData1);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Calculate2Test()
    {
        // Arrange
        var expected = 781;
        var createSize = 20;

        // Act
        var result = SolutionP2.Calculate(_testData2, createSize);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Calculate3Test()
    {
        // Arrange
        var expected = 3;

        // Act
        var result = SolutionP3.Calculate(_testData3);

        // Assert
        result.Should().Be(expected);
    }
}
