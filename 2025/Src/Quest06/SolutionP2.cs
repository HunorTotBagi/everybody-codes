namespace Src.Quest06;

public class SolutionP2
{
    public static int CountMentors(string input)
    {
        var mentors = new List<char> { 'A', 'B', 'C' };
        var order = ReadFile(input);
        var result = 0;

        foreach (char mentor in mentors)
        {
            for (var i=0; i < order.Length; i++)
            {
                if (order[i] == mentor)
                {
                    var aprentice = char.ToLower(mentor);

                    for (var j=i+1; j < order.Length; j++)
                    {
                        if (order[j] == aprentice)
                            result++;
                    }
                }
            }
        }

        return result;
    }

    public static string ReadFile(string input)
    {
        return File.ReadLines(input).First();
    }
}
