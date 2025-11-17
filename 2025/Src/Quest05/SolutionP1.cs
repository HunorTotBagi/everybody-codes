namespace Src.Quest05;

public class SolutionP1
{
    public static string Calculate(string filePath)
    {
        var input = ReadNumbers(filePath);

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

        return code;
    }

    public static List<int> ReadNumbers(string filePath)
    {
        var lines = File.ReadAllLines(filePath)[0];

        var a = lines.Split(":");
        var b = a[1].Split(",");

        var result = new List<int>();

        foreach (var item in b)
            result.Add(int.Parse(item));

        return result;
    }
}