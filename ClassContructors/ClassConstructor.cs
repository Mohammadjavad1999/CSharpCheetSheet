namespace ClassConstructor;

public class ClassConstructor(string firstName, string lastName)
{
    static ClassConstructor()
    {

        Console.WriteLine("Static Constructor Execute Once Per Type rather Than Constructor Which Execute Per Instance");
        Console.WriteLine("Static Constructor is Parameterless and and It's Invokes Prior The Type Being Used");
    }
    public static string x = "If No Static Constructor Exist in The Type The Static Fields Executes Prior Type Initlization";
    private string _firstName { get => firstName; }
    private string _lastName { get => lastName; }
    public string FullName()
    {
        return $"{_firstName} ,{_lastName}";
    }
}