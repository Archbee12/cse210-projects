using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
          
        int sum = 0;
        foreach (int userNumber in numbers)
        {
            sum += userNumber;
        }     
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int bestSoFar = -1;

        foreach (int userNumber in numbers)
            if (userNumber > bestSoFar)
            {
                bestSoFar = userNumber;
            }
                
        Console.WriteLine($"The largest number is {bestSoFar}");
    }
}