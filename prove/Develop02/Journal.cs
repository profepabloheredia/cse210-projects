
using System.IO; 
public class Journal 
{   
    public List<Entry> _entries= new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
         foreach (Entry entry in _entries)
        {
           entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                string line =($"{entry._date},{entry._prompText},{entry._entryText}");
               
                outputFile.WriteLine(line);
            }
            Console.WriteLine("all were saved!");
        }
    }
    public void LoadFromFile(string file)
    {
        
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];
            
            Entry loadEntry =new Entry();
            loadEntry._date =date;
            loadEntry._prompText= prompt;
            loadEntry._entryText = answer;
            
            AddEntry(loadEntry);
        }

        Console.WriteLine("\n\t----- Your Journal File----");
        DisplayAll();
        Console.WriteLine("\t     ----- End----");
    }
}