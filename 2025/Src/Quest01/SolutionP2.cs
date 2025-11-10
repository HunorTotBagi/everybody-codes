namespace Src.Quest01;

public class SolutionP2
{
    public static (string[] names, string[] directions) ReadNamesAndDirections(string testData)
    {
        var lines = File.ReadAllLines(testData);

        return (lines[0].Split(","), lines[2].Split(","));
    }

    public static string Solve(string filePath) 
    {
        var (listOfNames, listOfMoves) = ReadNamesAndDirections(filePath);

        var i = 0;
        var distance = 0;

        foreach (var move in listOfMoves)
        {
            distance = int.Parse(move.Substring(1));
            if (move[0] == 'R')
            {
                i += distance;
                if (i > listOfNames.Length - 1)
                    i %= listOfNames.Length;
            }
            else
            {
                i -= distance;
                if (i < 0)
                    i = ((i % listOfNames.Length) + listOfNames.Length) % listOfNames.Length;
            }


        }

        return listOfNames[i];
    }
}
