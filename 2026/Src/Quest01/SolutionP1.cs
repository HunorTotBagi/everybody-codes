namespace Src.Quest01;

public class SolutionP1
{
    public static double Calculate(string input)
    {
        var finalSumm = 0;
        var (result, colors) = ReadData(input);

        for (var i= 0; i<colors.Count; i++) 
        {
            var first = ConvertStringToNumber(colors[i][0]);
            var second = ConvertStringToNumber(colors[i][1]);
            var third = ConvertStringToNumber(colors[i][2]);

            if (second > first && second > third)
                finalSumm += result[i];
        }

        return finalSumm;
    }

    public static double ConvertStringToNumber(string input)
    {
        var length = input.Length;
        double result = 0;
        var power = 0;

        for (var i = length - 1; i >= 0; i--)
        {
            if (char.IsUpper(input[i]))
            {
                result += Math.Pow(2, power);
            }
                
            power++;
        }


        return result;
    }


    public static (List<int> results, List<string[]> colors) ReadData(string input)
    {
        var results = new List<int>();
        var colors = new List<string[]>();

        var lines = File.ReadAllLines(input);

        foreach (var line in lines)
        {
            var parts = line.Split(":");

            results.Add(int.Parse(parts[0]));
            colors.Add(parts[1].Split(" "));
        }

        return (results, colors);
    }
}
