using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].Display();
        }
    }

    public void SaveToFile(String file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                outputFile.WriteLine($"Date: |{_entries[i]._date}| - Prompt: |{_entries[i]._promptText}|{_entries[i]._entryText}");
            }
        }
    }

    public void LoadFromFile(String file)
    {
        if (File.Exists(file))
        {
            _entries.Clear();

            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                String entryDate = parts[1];
                String entryPrompt = parts[3];
                String entryAnswer = parts[4];

                Entry fileEntry = new Entry();
                fileEntry._date = entryDate;
                fileEntry._promptText = entryPrompt;
                fileEntry._entryText = entryAnswer;

                _entries.Add(fileEntry);
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("File does not exist.");
        }
    }
}