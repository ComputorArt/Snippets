// C# program to validate the Mobile 
// Number using Regular Expressions 
using System;
using System.Text.RegularExpressions;

class Regex_Csharp
{

    // Main Method 
    static void Main(string[] args)
    {
        // Input strings to Match 
        String _strInput = "start";
        while(_strInput != "end")
        {
            Console.WriteLine("Enter a string");
            _strInput = Console.ReadLine();
            Console.WriteLine("The Given String {0} is {1} ", _strInput,
                       validateTestInputString(_strInput) ? "->valid" : "->Invalid");
        }

        Console.ReadKey();
    }
    // method containing the regex 
    public static bool validateTestInputString(string inString)
    {
        string strRegex = @"ca*t\B";
        Regex re = new Regex(strRegex);
        if (re.IsMatch(inString))
            return (true);
        else
            return (false);
    }
}