namespace SwitchStatement;

public static class SwitchStateMentExercise
{
    public static void ExecuteWithObjectInput(object input)
    {
        switch (input)
        {
            case int i when i > 1000:
                Console.WriteLine("Input is Integer");
                break;
            case bool b when b is false:
                Console.WriteLine("This is A Boolean ");
                break;

            default:
                throw new Exception("This Input Type is Undefined");

        }
    }

    public static void ExecuteWithStringInput(string input)
    {
        int i = input switch
        {
            "First" => 1,
            "Second" => 2,
            _ => 0

        };

        Console.WriteLine($"The Value is :{i}");
    }

    public static void ExectueWithMultipleValues(string firstName, int age)
    {
        string lastName = (firstName, age) switch
        {
            ("Mohammadjavad", 26) => "Poosti",
            ("Mohammad", 55) => "Hosseini",
            _ => "Unknown Person"

        };
        Console.WriteLine(lastName);

    }
}