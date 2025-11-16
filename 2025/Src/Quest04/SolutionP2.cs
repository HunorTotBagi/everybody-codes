namespace Src.Quest04;

public class SolutionP2
{
    public static long Calculate(string filePath, long targetLastTurns = 10_000_000_000_000L)
    {
        var gears = ReadNumber(filePath);

        var first = gears[0];
        var last = gears[^1];

        checked
        {
            long numerator = targetLastTurns * last;
            long result = (numerator + first - 1) / first;
            return result;
        }
    }

    public static long[] ReadNumber(string filePath) 
    {
        var lines = File.ReadAllLines(filePath);

        return lines.Select(long.Parse).ToArray();
    }
}
