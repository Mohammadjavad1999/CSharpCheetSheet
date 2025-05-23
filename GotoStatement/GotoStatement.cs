using System;
namespace gotoStatement;

public static class gotoStatementExercise
{
    public static void Execute()
    {
        int i = 0;
    firstStep:
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;

            goto firstStep;
        }
    }
}