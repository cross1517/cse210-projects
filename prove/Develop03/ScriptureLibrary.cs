using System;

public class ScriptureLibrary
{
    private Dictionary<string, Scripture> _scriptures = new Dictionary<string, Scripture>();
    private List<string> references = new List<string>();

    public void LoadFromFile(string Scriptures)
    {
        foreach (string line in File.ReadLines(Scriptures))
        {
            string[] parts = line.Split('|');
            string referenceText = parts[0];
            string scriptureText = parts[1];
            references.Add(referenceText);

            
            Reference reference = SeparateReference(referenceText);
            Scripture scripture = new Scripture(reference, parts[1]);
            _scriptures[referenceText] = scripture;
        }
    }

    private Reference SeparateReference(string referenceText)
    {
        string[] parts = referenceText.Split(':');
        if (parts.Length == 4)
        {
            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);
            int endVerse = int.Parse(parts[3]);
            return new Reference(book, chapter, verse, endVerse);
        }

        else
        {
            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);
            return new Reference(book, chapter, verse);
        }
    }

    public string RandomScripture()
    {
        Random random = new Random();
        int randomScripture = random.Next(0, references.Count);
        return references[randomScripture];
    }

    public Scripture GetScripture(string referenceText)
    {
        return _scriptures[referenceText];
    }


}