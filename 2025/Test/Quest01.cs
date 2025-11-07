using FluentAssertions;
using Src.Quest01;
using Xunit;

namespace Test;

public class Quest01
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var names = "Ardenisis,Grimindor,Silirin,Quorthyn,Kalxeth,Xildar,Kharpyr,Hyracion,Thyrosdaros,Havoris";
        var moves = "L9,R1,L5,R9,L1,R3,L2,R9,L9,R4,L6";

        // Act
        var result = SolutionP1.Solve(names, moves);

        // Assert
        result.Should().Be("Ardenisis");
    }

    [Fact]
    public void Test2()
    {
        // Arrange
        var names = "Ardenisis,Grimindor,Silirin,Quorthyn,Kalxeth,Xildar,Kharpyr,Hyracion,Thyrosdaros,Havoris";
        var moves = "L9,R1,L5,R9,L1,R3,L2,R9,L9,R4,L6";

        // Act
        var result = SolutionP2.Solve(names, moves);

        // Assert
        result.Should().Be("Ardenisis");
    }
}
