using System.Diagnostics.Contracts;

public class Entry
{//declaring feilds 
    public string _date;
    public string _promptText;
    public string _response;

//constructor method for Entry class. date prompt and response perameters
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _promptText = prompt;
        _response = response;
    }



//Display method
    public string DisplayEntry()
    {
        //Console.WriteLine($"Date:{_date} Prompt:{_promptText} Entry text: {_response}");
        //interpolation 
        return $"Entry, {_date}, {_promptText}, {_response}";
        // return _date + " " + _prompt + " " + _response;
    }
}