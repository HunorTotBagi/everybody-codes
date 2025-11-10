using FluentAssertions;
using Src.Quest02;
using Xunit;

namespace Test;

public class Quest02Test
{
    private readonly string _testData = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest02/testData.txt";

    [Fact]
    public void ReadNumbersTest()
    {
        // Act
        var (number1, number2) = SolutionP1.ReadNumbers(_testData);

        // Assert
        number1.Should().Be(25);
        number2.Should().Be(9);
    }

    [Fact]
    public void AddTest()
    {
        // Arrange
        var a = new int[] { 1, 1 };
        var b = new int[] { 2, 2 };

        // Act
        var result = SolutionP1.Add(a, b);

        // Assert
        result.Should().BeEquivalentTo([3,3]);
    }

    [Fact]
    public void MultiplyTest()
    {
        // Arrange
        var a = new int[] { 1, 1 };
        var b = new int[] { 2, 2 };

        // Act
        var result = SolutionP1.Multiply(a, b);

        // Assert
        result.Should().BeEquivalentTo([0, 4]);
    }

    [Fact]
    public void DivisionTest()
    {
        // Arrange
        var a = new int[] { 10, 12 };
        var b = new int[] { 2, 2 };

        // Act
        var result = SolutionP1.Division(a, b);

        // Assert
        result.Should().BeEquivalentTo([5, 6]);
    }

    [Fact]
    public void SolutionP1SolveTest()
    {
        // Arrange
        var expected = new int[] { 357, 862 };

        // Act
        var result = SolutionP1.Calc(_testData);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}
