using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphaNumeric = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._-'";
            string input = "Today is Friday. Tommorrow will be saturday, followed by Sunday.";
            string pattern = @"[Ss]\S+";
            pattern = @"\W"; 
            input = alphaNumeric;
            var parser = new RegexTest();
            parser.PrintOutMatches(input, pattern);
            Console.ReadKey();
        }

        public class RegexTest
        {
            public void PrintOutMatches(string input, string pattern)
            {
                var regex = new Regex(pattern);
                var matches = regex.Matches(input);
                Console.WriteLine("Input: {0}", input);
                Console.WriteLine("Pattern: {0}", pattern);
                if (matches == null)
                {
                    Console.WriteLine("No matches found.", input);
                    return;
                }
                if (matches != null && matches.Count > 0)
                {
                    Console.WriteLine("Total Match: {0}", matches.Count);

                    foreach (var match in matches)
                    {
                        Console.WriteLine(match);
                    }
                }
                return;
            }
        }
    }
}
