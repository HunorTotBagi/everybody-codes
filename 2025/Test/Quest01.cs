using FluentAssertions;
using Src.Quest01;
using Xunit;

namespace Test;

public class Quest01
{
    private readonly string _testData1 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest01/testData1.txt";
    private readonly string _testData2 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest01/testData2.txt";
    private readonly string _testData3 = AppDomain.CurrentDomain.BaseDirectory + "../../../../Src/Quest01/testData3.txt";

    [Fact]
    public void ReadNames()
    {
        // Arrange
        var expectedNames = new[] { "Vyrdax","Drakzyph","Fyrryn","Elarzris" };
        var expectedDirections = new[] { "R3", "L2", "R3", "L1" };

        // Act
        var (names, directions) = SolutionP1.ReadNamesAndDirections(_testData1);

        // Assert
        names.Should().BeEquivalentTo(expectedNames);
        directions.Should().BeEquivalentTo(expectedDirections);
    }

    [Fact]
    public void SolutionP1SolveTest()
    {
        // Arrange
        var expectedNames = "Fyrryn";

        // Act
        var result = SolutionP1.Solve(_testData1);

        // Assert
        result.Should().Be(expectedNames);
    }

    [Fact]
    public void SolutionP2SolveTest()
    {
        // Arrange
        var expectedNames = "Elarzris";

        // Act
        var result = SolutionP2.Solve(_testData2);

        // Assert
        result.Should().Be(expectedNames);
    }

    [Fact]
    public void SolutionP3SolveTest()
    {
        // Arrange
        var expectedNames = "Drakzyph";

        // Act
        var result = SolutionP3.Solve(_testData3);

        // Assert
        result.Should().Be(expectedNames);
    }
}
