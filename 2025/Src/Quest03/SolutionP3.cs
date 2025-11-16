namespace Src.Quest03;

public class SolutionP3
{
    public static int Calculate(string filePath)
    {
        var input = ReadNumbers(filePath);

        var dict = new Dictionary<int, int>();

        foreach (var number in input)
        {
            if (dict.ContainsKey(number))
                dict[number]++;

            else
                dict[number] = 1;
        }

        return dict.Values.Max();
    }

    public static int[] ReadNumbers(string filePath)
    {
        var line = File.ReadLines(filePath).First();

        return line.Split(",").Select(int.Parse).ToArray();
    }
}
