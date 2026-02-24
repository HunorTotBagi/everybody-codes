using FluentAssertions;
using Src.Quest07;
using Xunit;

namespace Test;

public class Quest07Test
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest07/testData1.txt";
    
    [Fact]
    public void ReadFileTest()
    {
        // Arrange
        var expectedNames = new string[] { "Oronris", "Urakris", "Oroneth", "Uraketh" };
        var expectedRules = new Dictionary<string, string[]>
        {
            { "r", new string[] { "a", "i", "o" } },
            { "i", new string[] { "p", "w" } },
            { "n", new string[] { "e", "r" } },
            { "o", new string[] { "n", "m" } },
            { "k", new string[] { "f", "r" } },
            { "a", new string[] { "k" } },
            { "U", new string[] { "r" } },
            { "e", new string[] { "t" } },
            { "O", new string[] { "r" } },
            { "t", new string[] { "h" } }
        };

        // Act
        var (names, rules) = SolutionP1.ReadFile(_testData1);

        // Assert
        names.Should().BeEquivalentTo(expectedNames);
        rules.Should().BeEquivalentTo(expectedRules);
    }
}
