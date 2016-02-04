using System;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Twitter
{

    public class Twitter
    {
        private double m_length = 0;
        private Twitter()
        {
        }

        public double Length //gets length of tweet
        {
            get { return m_length; }
        }

        public static void Main()
        {
            DateTime date = DateTime.Now;
            int Uppercase_count = 0;
            int Lowercase_count = 0;
            int mentions = 0;
            bool ment;
            int topic = 0;
            //int top = 0;
            int special_char = 0;


            //Console.WriteLine("Tweet something!"); Can create your own string
            // string str = Console.ReadLine(); 
            string str = "@franky goes to #Hollywood!1!";
            string strx = str.Replace(" ", "");

            foreach (char input in str)
            {
                if (input == '@') { mentions++; }
                else if (input == '#') { topic++; }
                else if (input == '!' || input == '?' || input == '"' || input == '$' || input == '%' || input == '^' || input == '&' || input == '*' ||
                    input == '-' || input == '+' || input == '=' || input == '_' || input == '[' || input == ']' || input == '(' || input == ')' || input == ';' ||
                        input == ':' || input == '/' || input == ',' || input == '>' || input == '<')
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
            if (str.Length <= 140) //outputs data
            {
                int digitsCount = str.Count(c => char.IsDigit(c));
                Console.WriteLine("Your tweet is:");
                Console.WriteLine(str + "\n");
                Console.WriteLine("The length of the full tweet: {0}", str.Length);
                Console.WriteLine("The number of characters without blank spaces: {0}", strx.Length);
                Console.WriteLine("The number of uppercase letters: {0}", Uppercase_count);
                Console.WriteLine("The number of lowercase letters: {0}", Lowercase_count);
                Console.WriteLine("Number count: {0}", digitsCount);
                Console.WriteLine("The number of special characters: {0}", special_char);
                Console.WriteLine("The number of mentions: {0}", mentions);
                if (mentions == 1) { Console.WriteLine("Contains 1 mention: True"); }
                else { Console.WriteLine("No mentions!"); }
                if (topic == 1) { Console.WriteLine("Contains 1 topic: True"); }
                else { Console.WriteLine("No topics!"); }
                Console.WriteLine("Written on {0}", date);


                Debug.Assert(date != null, "There's a problem with your computer's time system."); //Debug Assertion for unit test


                {
                    Debug.Assert(str.Length <= 140, "Your tweet exceeds the maximum number of characters"); //Debug Assertion for unit test
                }
                Console.ReadLine();
            }
        }
    }
}
    
