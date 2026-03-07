namespace Src.Quest01;

public class SolutionP3
{
    public static double Calculate(string input)
    {
        var (scales, colors) = SolutionP1.ReadData(input);
        var calculatedValues = new List<(double, string)>();

        for (var i = 0; i < colors.Count; i++)
        {
            var first = SolutionP1.ConvertStringToNumber(colors[i][0]);
            var second = SolutionP1.ConvertStringToNumber(colors[i][1]);
            var third = SolutionP1.ConvertStringToNumber(colors[i][2]);
            var shine = SolutionP1.ConvertStringToNumber(colors[i][3]);

            if (first > second && first > third && shine <= 30)
                calculatedValues.Add((scales[i], "red-matte"));

            else if (first > second && first > third && shine >= 33)
                calculatedValues.Add((scales[i], "red-shiny"));

            else if (second > first && second > third && shine <= 30)
                calculatedValues.Add((scales[i], "green-matte"));

            else if (second > first && second > third && shine >= 33)
                calculatedValues.Add((scales[i], "green-shiny"));

            else if (third > first && third > second && shine <= 30)
                calculatedValues.Add((scales[i], "blue-matte"));

            else if (third > first && third > second && shine >= 33)
                calculatedValues.Add((scales[i], "blue-shiny"));
        }

        var dict = new Dictionary<string, int>();

        foreach (var value in calculatedValues)
        {
            var key = value.Item2;

            if (dict.ContainsKey(key))
                dict[key]++; 

            else
                dict[key] = 1;
        }

        var mostItemsByColorShine = dict.MaxBy(x => x.Value).Key;

        double result = 0;
        foreach (var value in calculatedValues)
            if (value.Item2 == mostItemsByColorShine)
                result += value.Item1;

        return result;
    }
}
