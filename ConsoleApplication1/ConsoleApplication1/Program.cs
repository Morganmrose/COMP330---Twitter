using System;
using System.Linq;
class Twitter
{
    public static void Main()
    {
        Console.WriteLine("Tweet something!\n");
        string str = Console.ReadLine();
        int length = str.Length;
        Console.WriteLine("The length of '{0}' is {1}", str, str.Length);

      
    
        str = str.Replace(" ", "");
        
        int Uppercase_count = 0;
        int Lowercase_count = 0;
        int mentions = 0;
        int digitsCount = str.Count(c => char.IsDigit(c));

        foreach(char input in str)
            {
                if (Char.IsUpper(input))
                    Uppercase_count++;

                else if (Char.IsLower(input))
                    Lowercase_count++;
                else if (str.Contains("@"))
                    mentions++;

            }
        Console.WriteLine("The number of characters without blank spaces are {0}", str.Length);
        Console.WriteLine("The number of uppercase letters in this tweet is: {0}", Uppercase_count);
        Console.WriteLine("The number of lowercase letters in this tweet is: {0}", Lowercase_count);
        Console.WriteLine("The number of numbers in this tweet is: {0}", digitsCount);
        Console.WriteLine("The number of mentions in this tweet are: {0}", mentions);


        
        Console.ReadLine();
    }
}