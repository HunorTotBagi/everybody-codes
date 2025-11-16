using FluentAssertions;
using Src.Quest04;
using Xunit;

namespace Test;

public class Quest04Test
{
    private readonly string _testData11 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData11.txt";
    private readonly string _testData12 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData12.txt";

    [Fact]
    public void ReadNumbersTest()
    {
        // Arrange
        var expected = new float[] { 128, 64, 32, 16, 8 };

        // Act
        var result = SolutionP1.ReadNumber(_testData11);

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
        var result = SolutionP1.Calculate(_testData11, numberOfTurns);

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
        var result = SolutionP1.Calculate(_testData12, numberOfTurns);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest3()
    {
        // Arrange
        var expected = 625000000000;

        // Act
        var result = SolutionP2.Calculate(_testData11);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest4()
    {
        // Arrange
        var expected = 1274509803922;

        // Act
        var result = SolutionP2.Calculate(_testData12);

        // Assert
        result.Should().Be(expected);
    }
}
