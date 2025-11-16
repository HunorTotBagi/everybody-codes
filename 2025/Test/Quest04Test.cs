using FluentAssertions;
using Src.Quest04;
using Xunit;

namespace Test;

public class Quest04Test
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData1.txt";
    private readonly string _testData2 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData2.txt";
    private readonly string _testData3 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData3.txt";
    private readonly string _testData4 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest04/testData4.txt";

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
        var turns = 10000000000000;
        var expected = 625000000000;

        // Act
        var result = SolutionP2.Calculate(_testData1, turns);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest4()
    {
        // Arrange
        var turns = 10000000000000;
        var expected = 1274509803922;

        // Act
        var result = SolutionP2.Calculate(_testData2, turns);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void ReadNumbersTest2()
    {
        // Arrange
        var expected = new List<double[]>
        {
            new double[] { 5, 5 },
            new double[] { 10, 10 },
            new double[] { 20, 5 }
        };

        // Act
        var result = SolutionP3.ReadNumber(_testData3);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ReadNumbersTest3()
    {
        // Arrange
        var expected = new List<double[]>
        {
            new double[] { 5, 7 },
            new double[] { 21, 18 },
            new double[] { 36, 27 },
            new double[] { 27, 10 },
            new double[] { 50, 10 },
            new double[] { 50, 11 }
        };

        // Act
        var result = SolutionP3.ReadNumber(_testData4);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void CalculateTest5()
    {
        // Arrange
        var turns = 100;
        var expected = 400;

        // Act
        var result = SolutionP3.Calculate(_testData3, turns);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest6()
    {
        // Arrange
        var turns = 100;
        var expected = 6818;

        // Act
        var result = SolutionP3.Calculate(_testData4, turns);

        // Assert
        result.Should().Be(expected);
    }
}
