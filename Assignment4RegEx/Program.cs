using System;
using System.Text.RegularExpressions;
class Program
{
    // a regular expression pattern for a five-letter word
    // that starts with "a" and ends with "e"  
    static string pattern = "^a...e$";

    static void Main()
    {
        // create an instance of Regex class and
        //  pass the regular expression (i.e pattern)
        Regex rg = new Regex(pattern);

        // IsMatch() returns true if "apple" matches the regular expression 
        if (rg.IsMatch("apple"))
        {
            Console.WriteLine("String matches the pattern");
        }
        else
        {
            Console.WriteLine("String doesn't match the pattern");
        }
    }
}