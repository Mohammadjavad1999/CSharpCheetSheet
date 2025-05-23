namespace UsingStatement;

using NumberList = decimal[];
public static class UsingStatementExercise
{
    public static void Execute()
    {
        NumberList numbers = { 1.2m, 3.3m, 5.01m };
        System.Console.WriteLine(numbers);
    }
}