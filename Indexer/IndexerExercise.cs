namespace IndexerExercise;

public class Sentence
{
    string[] words = "This is A word".Split();
    public string this[int index]
    {
        get { return words[index]; }
        set { words[index] = value; }
    }
}