namespace Src.Quest04;

public class SolutionP1
{
    public static int Calculate(string filePath, int numberOfTurns)
    {
        var input = ReadNumber(filePath);
        var ratio = (double)input[0] / input[^1];

        return (int)Math.Floor(numberOfTurns * ratio);
    }

    public static int[] ReadNumber(string filePath) 
    {
        var lines = File.ReadAllLines(filePath);

        return lines.Select(int.Parse).ToArray();
    }
}
