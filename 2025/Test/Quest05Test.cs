using FluentAssertions;
using Src.Quest05;
using Xunit;

namespace Test;

public class Quest05Test
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest05/testData1.txt";
    private readonly string _testData2 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest05/testData2.txt";

    [Fact]
    public void ReadNamesTest1()
    {
        // Arrange
        var expected = new List<int> { 5, 3, 7, 8, 9, 10, 4, 5, 7, 8, 8 };

        // Act
        var result = SolutionP1.ReadNumbers(_testData1);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Calculate1Test()
    {
        // Arrange
        var expected = "581078";

        // Act
        var result = SolutionP1.Calculate(_testData1);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void Calculate2Test()
    {
        // Arrange
        var expected = 77053;

        // Act
        var result = SolutionP2.Calculate(_testData2);

        // Assert
        result.Should().Be(expected);
    }
}
