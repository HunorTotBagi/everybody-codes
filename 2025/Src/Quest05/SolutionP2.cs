namespace Src.Quest05;

public class SolutionP2
{
    public static double Calculate(string filePath)
    {
        var input = ReadNumbers(filePath);

        var min = double.MaxValue;
        var max = double.MinValue;

        foreach (var item in input)
        {
            var currentQuality = GetSwordQuality(item.ToArray());

            if (currentQuality < min)
                min = currentQuality;

            if (currentQuality > max)
                max = currentQuality;
        }

        return max - min;
    }
    public static double GetSwordQuality(int[] input)
    {
        var result = new List<int[]>();
        var code = "";

        foreach (var number in input)
        {
            var tracker = false;
            foreach (var item in result)
            {
                if (number < item[1] && item[0] == 0)
                {
                    item[0] = number;
                    tracker = true;
                    break;
                }
                else if (item[1] < number && item[2] == 0)
                {
                    item[2] = number;
                    tracker = true;
                    break;
                }
            }
            if (!tracker)
            {
                result.Add([0, number, 0]);
                code += number.ToString();
            }
        }

        return double.Parse(code);
    }

    public static List<List<int>> ReadNumbers(string filePath)
    {
        var lines = File.ReadAllLines(filePath);


        var result = new List<List<int>>();

        foreach (var line in lines)
        {
            var holder = new List<int>();

            var a = line.Split(":");
            var b = a[1].Split(",");

            foreach (var item in b)
                holder.Add(int.Parse(item));

            result.Add(holder);
        }

        return result;
    }
}