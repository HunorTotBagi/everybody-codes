namespace Src.Quest01;

public class SolutionP2
{
    public static double Calculate(string input)
    {
        var calculatedValues = new List<double[]>();
        var (result, colors) = SolutionP1.ReadData(input);

        for (var i = 0; i < colors.Count; i++)
        {
            var first = SolutionP1.ConvertStringToNumber(colors[i][0]);
            var second = SolutionP1.ConvertStringToNumber(colors[i][1]);
            var third = SolutionP1.ConvertStringToNumber(colors[i][2]);
            var shine = SolutionP1.ConvertStringToNumber(colors[i][3]);

            calculatedValues.Add([result[i], first + second + third, shine]);
        }

        double max = -1;
        foreach (var value in calculatedValues)
        {
            if (value[2] > max)
                max = value[2];
        }

        var candidates = new List<double[]>();

        foreach (var value in calculatedValues)
            if (value[2] == max)
                candidates.Add(value);

        var min = candidates[0][1];
        var finalResult = candidates[0][0];

        foreach (var candidate in candidates)
        {
            if (candidate[1] < min)
            {
                finalResult = candidate[0];
                min = candidate[1];
            }
        }

        return finalResult;
    }
}
