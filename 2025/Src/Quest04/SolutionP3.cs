 namespace Src.Quest04;

public class SolutionP3
{
    public static double Calculate(string filePath, long turns)
    {
        var input = ReadNumber(filePath);
        double result = 1;

        foreach (var item in input)
            result *= item[0] / item[1];

        return Math.Floor(result * turns);
    }

    public static List<double[]> ReadNumber(string filePath) 
    {
        var lines = File.ReadAllLines(filePath);
        var result = new List<double[]>();

        var asd = lines[1].Split('|');
        var first = new double[] { double.Parse(lines[0]) , double.Parse(asd[0]) };

        result.Add(first);

        for(var i=1; i<lines.Length - 1; i++)
        {
            var a = lines[i].Split('|');
            var b = lines[i + 1].Split('|');

            result.Add([double.Parse(a[1]), double.Parse(b[0])]);
        }

        return result;
    }
}
