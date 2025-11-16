using FluentAssertions;
using Src.Quest04;
using Xunit;

namespace Test;

public class Quest04Test
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData1.txt";
    private readonly string _testData2 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData2.txt";

    [Fact]
    public void ReadNumbersTest()
    {
        // Arrange
        var expected = new double[] { 128, 64, 32, 16, 8 };

        // Act
        var result = SolutionP1.ReadNumber(_testData1);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void CalculateTest1()
    {
        // Arrange
        var numberOfTurns = 2025;
        var expected = 32400;

        // Act
        var result = SolutionP1.Calculate(_testData1, numberOfTurns);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest2()
    {
        // Arrange
        var numberOfTurns = 2025;
        var expected = 15888;

        // Act
        var result = SolutionP1.Calculate(_testData2, numberOfTurns);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest3()
    {
        // Arrange
        var expected = 625000000000;

        // Act
        var result = SolutionP2.Calculate(_testData1);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest4()
    {
        // Arrange
        var expected = 1274509803922;

        // Act
        var result = SolutionP2.Calculate(_testData2);

        // Assert
        result.Should().Be(expected);
    }
}
