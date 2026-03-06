using FluentAssertions;
using Src.Quest01;
using Xunit;

namespace Test;

public class Quest01Tests
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest01/testData1.txt";

    [Fact]
    public void ReadData()
    {
        // Arrange
        var expectedResults = new List<int> { 2456, 7689, 3145, 6710 };
        var expectedColors = new List<string[]>
        {
            new[] { "rrrrrr", "ggGgGG", "bbbbBB" },
            new[] { "rrRrrr", "ggGggg", "bbbBBB" },
            new[] { "rrRrRr", "gggGgg", "bbbbBB" },
            new[] { "rrrRRr", "ggGGGg", "bbBBbB" }
        };

        // Act
        var (results, colors) = SolutionP1.ReadData(_testData1);

        // Assert
        results.Should().BeEquivalentTo(expectedResults);
        colors.Should().BeEquivalentTo(expectedColors);
    }

    [Theory]
    [InlineData(11, "ggGgGG")]
    [InlineData(0, "rrrrrr")]
    [InlineData(7, "bbbBBB")]
    [InlineData(6, "rrrRRr")]
    [InlineData(55, "GGgGGG")]
    public void ConvertStringToNumberTest(int expected, string input)
    {
        // Act
        var result = SolutionP1.ConvertStringToNumber(input);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CalculateTest()
    {
        // Arrange
        var expected = 9166;

        // Act
        var result = SolutionP1.Calculate(_testData1);

        // Assert
        result.Should().Be(expected);
    }
}
