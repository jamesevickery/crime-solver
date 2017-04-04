using System;
using System.Collections.Generic;

namespace CrimeSolver
{
    class Program
    {
        /// <summary>
        /// This is the main function of the code, where the code starts.
        /// It calls the SolveCrime function then uses a ReadLine to hold the terminal.
        /// </summary>
        static void Main(string[] args)
        {
            SolveCrime();
            Console.ReadLine();
        }

        /// <summary>
        /// The method to test every possible combination of true and false.
        /// </summary>
        private static void SolveCrime()
        {
            // Create a new array of boolean values: `true` and `false`.
            // This just saves us from typing {true, false} for every foreach statement
            bool[] bools = new bool[] { true, false };

            // The foreach statements run for every value of `bools` (true and false)
            foreach (bool a in bools)
            {
                foreach (bool b in bools)
                {
                    foreach (bool c in bools)
                    {
                        foreach (bool d in bools)
                        {
                            // The `Valid` function is called with the suspects' statements.
                            // If all return `true` (mathematical tautology) then whoWasIt is called
                            if (Valid(!d, !b) &
                                Valid(!c, d) &
                                Valid(a, !d) &
                                Valid(c, !a))
                            {
                                bool[] s = new bool[] { a, b, c, d };
                                // Print list of convicts from whoWasIt method
                                Console.WriteLine(whoWasIt(ref s[0], ref s[1], ref s[2], ref s[3]));
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns `true` if x or y is true (but not both)
        /// So returns `false` if neither, or both, are true.
        /// </summary>
        private static bool Valid(bool x, bool y)
        {
            return ((!x && y) || (x && !y));
        }

        /// <summary>
        /// Outputs the name(s) of the convicted suspects
        /// </summary>
        /// <returns>A string, listing the convicts</returns>
        private static string whoWasIt<T>(ref T a, ref T b, ref T c, ref T d)
        {
            // Create list for convict names
            // IList Requires .NET 4+
            IList<string> names = new List<string>();

            // If the boolean value of the string of the suspects' variables are true, add them to a list of names
            if (bool.Parse(a.ToString())) names.Add("Alex");
            if (bool.Parse(b.ToString())) names.Add("Brad");
            if (bool.Parse(c.ToString())) names.Add("Charlie");
            if (bool.Parse(d.ToString())) names.Add("David");

            // Create readable string of convict names
            string convicts = string.Join(", ", names);

            // Generate resultant string and return to SolveCrime
            string result = "Possible convict(s): The crime was commited by: ";
            result += convicts + ".";
            return result;
        }
    }
}
