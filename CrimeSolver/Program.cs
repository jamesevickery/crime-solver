using System;
using System.Collections.Generic;

namespace CrimeSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            SolveCrime();
            Console.ReadLine();
        }

        static void SolveCrime()
        {
            bool[] bools = new bool[] { true, false };

            foreach (bool a in bools)
            {
                foreach (bool b in bools)
                {
                    foreach (bool c in bools)
                    {
                        foreach (bool d in bools)
                        {
                            if (Valid(!d, !b) &
                                Valid(!c, d) &
                                Valid(a, !d) &
                                Valid(c, !a))
                            {
                                Console.WriteLine(whoWasIt(a, b, c, d));
                            }
                        }
                    }
                }
            }

        }

        static bool Valid(bool x, bool y)
        {
            return ((!x && y) || (x && !y));
        }

        static string whoWasIt(bool a, bool b, bool c, bool d)
        {
            IList<string> names = new List<string>();
            if (a) names.Add("Alex");
            if (b) names.Add("Brad");
            if (c) names.Add("Charlie");
            if (d) names.Add("David");
            string convicts = string.Join(", ", names);

            string result = "The crime was commited by: ";
            result += convicts + ".";
            return result;
        }
    }
}
