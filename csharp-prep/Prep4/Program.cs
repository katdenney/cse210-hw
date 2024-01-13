using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Welcome to Prep4!");
        Console.WriteLine("enter a list of numbers, type 0 when finished. ");
        List<int> numbersList = new List<int>();
        String userInput;
        int number;
        do
        {
        Console.Write("Type a number: ");
        userInput = Console.ReadLine();
        number = int.Parse(userInput);
        numbersList.Add(number);
        } while (number != 0);

        /*foreach ( int num in numbersList)
        {
            Console.WriteLine(num);
        }*/
        //compute the sum, or total, of the numbers in the list
        int sum = numbersList.Sum();
        Console.WriteLine($"The sum is:{sum}");
        //compute the average of the numbers in the list
        double average = numbersList.Average();
        Console.WriteLine($"The average is:{average}");
        //find the maximum, or largest,number in the list
        int largestNumber = numbersList.Max();
        Console.WriteLine($"Max number in list is {largestNumber}");


    }
}