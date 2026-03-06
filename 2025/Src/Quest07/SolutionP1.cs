namespace Src.Quest07;

public class SolutionP1
{
    public static (string[] names, Dictionary<string,string[]> rules) ReadFile(string input)
    {
        var lines = File.ReadLines(input).ToList();

        var names = lines[0].Split(',');

        var rules = new Dictionary<string, string[]>();
        for (var i = 2; i < lines.Count; i++)
        {
            var parts = lines[i].Split(" > ");
            var key = parts[0];
            var values = parts[1].Split(',');
            rules[key] = values;
        }

        return (names, rules);
    }
}
