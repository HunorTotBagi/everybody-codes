namespace Src.Quest03;

public class SolutionP1
{
    public static int Calculate(string filePath)
    {
        var input = ReadNumbers(filePath);

        var set = new HashSet<int>();
        var result = 0;

        foreach (var number in input)
            set.Add(number);


        foreach (var number in set)
            result += number;

        return result;
    }

    public static int[] ReadNumbers(string filePath)
    {
        var line = File.ReadLines(filePath).First();

        return line.Split(",").Select(int.Parse).ToArray();
    }
}
