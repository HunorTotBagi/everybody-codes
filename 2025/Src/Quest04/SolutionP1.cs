 namespace Src.Quest04;

public class SolutionP1
{
    public static int Calculate(string filePath, int numberOfTurns)
    {
        var input = ReadNumber(filePath);

        var ratio = input[0] / input[^1];

        return (int)(numberOfTurns * ratio);
    }

    public static double[] ReadNumber(string filePath) 
    {
        var lines = File.ReadAllLines(filePath);

        return lines.Select(double.Parse).ToArray();
    }
}
