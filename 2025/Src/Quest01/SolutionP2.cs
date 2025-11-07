namespace Src.Quest01;

public class SolutionP2
{
    public static string Solve(string names, string moves) 
    {
        var listOfNames = names.Split(",");
        var listOfMoves = moves.Split(",");

        var i = 0;
        var distance = 0;

        foreach (var move in listOfMoves)
        {
            distance = move[1];
            if (move[0] == 'R')
            {
                i += distance;
                if (i > listOfNames.Length)
                    i %= listOfNames.Length;
            }

            i -= distance;
            if (i < 0)
                i = Math.Abs(i %= listOfNames.Length);
        }


        return listOfNames[i];
    }
}
