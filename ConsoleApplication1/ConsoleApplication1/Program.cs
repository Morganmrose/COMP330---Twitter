using System;
using System.Linq;
using System.Text.RegularExpressions;
class Twitter
{

    public static void Main()
    {
        
        Console.WriteLine("Tweet something!\n");
        string str = Console.ReadLine();
        int length = str.Length;
        string strx = str.Replace(" ", "");
        
        int Uppercase_count = 0;
        int Lowercase_count = 0;
        int mentions = 0;
        int special_char=0;
        int digitsCount = str.Count(c => char.IsDigit(c));
    

        
        foreach (char input in str)
        {
            if (input == '@') { mentions++; }
            else if (input =='!'|| input =='?'||input =='"'||input =='#'||input =='$'||input =='%'||input =='^'||input =='&'||input =='*'||
                input =='-'||input =='+'||input =='='||input =='_'||input =='['||input ==']'||input =='('||input ==')'|| input ==';'||
                    input ==':'||input =='/'||input ==','||input =='>'||input =='<')
                //repetitive, but having problems implementing a regex
            {
                special_char++;
            }
          
            else if (Char.IsUpper(input))
            {
                Uppercase_count++;
            }
            else if (Char.IsLower(input))
            {
                Lowercase_count++;
            }

        }

        if (str.Length <= 140)
        {

            Console.WriteLine("The length of the full tweet: {0}", str.Length);
            Console.WriteLine("The number of characters without blank spaces: {0}", strx.Length);
            Console.WriteLine("The number of uppercase letters: {0}", Uppercase_count);
            Console.WriteLine("The number of lowercase letters: {0}", Lowercase_count);
            Console.WriteLine("Number count: {0}", digitsCount);
            Console.WriteLine("The number of special characters: {0}", special_char);
            Console.WriteLine("The number of mentions: {0}", mentions);
        }
        else
        {
            Console.WriteLine("Your tweet exceeds the maxium number of characters (140). Try again.");
            Main();
        }


        
        Console.ReadLine();
    }
}