using FluentAssertions;
using Src.Quest06;
using Xunit;

namespace Test;

public class Quest06Test
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest06/testData1.txt";
    private readonly string _testData2 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest06/testData2.txt";
    private readonly string _testData3 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest06/testData3.txt";

    [Fact]
    public void ReadFile()
    {
        // Arrange
        var expected = "ABabACacBCbca";

        // Act
        var result = SolutionP1.ReadFile(_testData1);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void CountMentors1Test()
    {
        // Arrange
        var expected = 5;

        // Act
        var result = SolutionP1.CountMentors(_testData1);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void CountMentors2Test()
    {
        // Arrange
        var expected = 11;

        // Act
        var result = SolutionP2.CountMentors(_testData2);

        // Assert
        result.Should().Be(expected);
    }
}