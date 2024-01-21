public class Journal
{

    public List<Entry>_entries = new List<Entry>();

    //constructor
    public Journal()
    {}

    public void AddEntry(string date,string prompt, string entry)
    {
        _entries.Add(new Entry(date, prompt, entry));

    }
    public void DisplayAll()
    {
        Console.WriteLine("Displaying Journal Entries");
        foreach (Entry e in _entries)
        {
            Console.WriteLine($"{e.DisplayEntry()}");
        }
    }
    public void SaveToFile()
    {
        Console.WriteLine("Enter a name for this file:");
        string fileName = Console.ReadLine();

        Console.WriteLine("Saving to file...");
        fileName += ".csv";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine(e.DisplayEntry());
            }
        }

    }
    public void LoadFromFile()
    {
        Console.WriteLine("Enter a file to read from:");
        string fileName = Console.ReadLine();
        fileName += ".csv";

        _entries = new List<Entry>();
        //adding a try catch here becuase I accidentally typed a number instead of a file name and it broke the program.
        try
        {

            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                //splitting lines into parts with .Split 
                //Console.WriteLine(line);
                string[] parts = line.Split(',');

                
                //new Entry object and adding that data to _entries list
                //Console.WriteLine($"{parts[0]} and {parts[1]}");
                Entry e = new Entry(parts[1], parts[2], parts[3]);
                _entries.Add(e);
                
            }

            Console.WriteLine("Finished loading the data.");
        }

        catch (Exception)
        {
            Console.WriteLine("Error ...");
        }
        

    }
}