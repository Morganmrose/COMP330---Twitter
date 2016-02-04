using System;

class Twitter
{
    public static void Main()
    {
        Console.WriteLine("Tweet something!\n");
        string str = Console.ReadLine();
        int length = str.Length;
        Console.WriteLine("The length of '{0}' is {1}", str, str.Length);

      
    
        str = str.Replace(" ", "");
        Console.WriteLine("The number of characters without blank spaces are {0}", str.Length); //
        int Uppercase_count = 0;
        int Lowercase_count = 0;
        foreach(char input in str)
            {
                if (Char.IsUpper(input))
                   Uppercase_count++;

                else if (Char.IsLower(input))
                    Lowercase_count++;


            }
        Console.WriteLine("The number of uppercase letters in this tweet is: {0}", Uppercase_count);
        Console.WriteLine("The number of lowercase letters in this tweet is: {0}", Lowercase_count);

        
        Console.ReadLine();
    }
}