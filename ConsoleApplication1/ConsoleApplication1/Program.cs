using System;

class Twitter
{
    public static void Main()
    {
        Console.WriteLine("Tweet something!\n");
        string str = Console.ReadLine();

        Console.WriteLine("1) The length of '{0}' is ", str, str.Length);

        int length = str.Length;
        Console.ReadLine();
    }
}