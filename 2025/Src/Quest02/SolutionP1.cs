namespace Src.Quest02;

public class SolutionP1
{
    public static int[] Calc(string filePath)
    {
        var (number1, number2) = ReadNumbers(filePath);

        var start = new int[] { 0, 0 };
        var input = new int[] { number1, number2 };

        var i = 0;
        while (i < 3)
        {
            start = Multiply(start, start);
            start = Division(start, [10, 10]);
            start = Add(start, input);
            i++;
        }

        return start;
    }

    public static (int number1, int number2) ReadNumbers(string filePath)
    {
        var line = File.ReadAllLines(filePath)[0];

        var a = line.Split("[");
        var b = a[1].Split(",");

        var number1 = int.Parse(b[0]);
        var number2 = int.Parse(b[1].Substring(0, b[1].Length - 1));

        return (number1, number2);
    }

    public static int[] Multiply(int[] a, int[] b) => [a[0] * b[0] - a[1] * b[1], a[0] * b[1] + a[1] * b[0]];

    public static int[] Division(int[] a, int[] b) => [a[0] / b[0], a[1] / b[1]];

    public static int[] Add(int[] a, int[] b) => [a[0] + b[0], a[1] + b[1]];
}
