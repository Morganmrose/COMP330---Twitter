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

        
        Console.ReadLine();
    }
}