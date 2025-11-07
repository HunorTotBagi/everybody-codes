using FluentAssertions;
using Src.Quest01;
using Xunit;

namespace Test;

public class Quest01
{
    private readonly string _testData = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest01/testData.txt";

    [Fact]
    public void ReadNames()
    {
        // Arrange
        var expectedNames = new[] { "Vyrdax","Drakzyph","Fyrryn","Elarzris" };
        var expectedDirections = new[] { "R3", "L2", "R3", "L1" };

        // Act
        var (names, directions) = SolutionP1.ReadNamesAndDirections(_testData);

        // Assert
        names.Should().BeEquivalentTo(expectedNames);
        directions.Should().BeEquivalentTo(expectedDirections);
    }
}
