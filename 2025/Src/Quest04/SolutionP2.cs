 namespace Src.Quest04;

public class SolutionP2
{
    public static double Calculate(string filePath, long turns)
    {
        var input = ReadNumber(filePath);

        return Math.Ceiling(turns * input[^1] / input[0]);
    }

    public static double[] ReadNumber(string filePath) 
    {
        var lines = File.ReadAllLines(filePath);

        return lines.Select(double.Parse).ToArray();
    }
}
