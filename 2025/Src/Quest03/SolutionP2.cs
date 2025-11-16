namespace Src.Quest03;

public class SolutionP2
{
    public static int Calculate(string filePath, int createSize)
    {
        var input = ReadNumbers(filePath);

        var set = new HashSet<int>();
        var result = 0;

        foreach (var number in input)
            set.Add(number);

        var sorted = set.ToList();
        sorted.Sort();

        for (var i=0; i < createSize; i++)
            result += sorted[i];

        return result;
    }

    public static int[] ReadNumbers(string filePath)
    {
        var line = File.ReadLines(filePath).First();

        return line.Split(",").Select(int.Parse).ToArray();
    }
}
