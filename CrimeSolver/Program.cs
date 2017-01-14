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
                                bool a_static = a;
                                bool b_static = b;
                                bool c_static = c;
                                bool d_static = d;
                                Console.WriteLine(whoWasIt(ref a_static, ref b_static, ref c_static, ref d_static));
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

        static string whoWasIt<T>(ref T a, ref T b, ref T c, ref T d)
        {
            IList<string> names = new List<string>();
            // Requires .NET 4+
            if (bool.Parse(a.ToString())) names.Add("Alex");
            if (bool.Parse(b.ToString())) names.Add("Brad");
            if (bool.Parse(c.ToString())) names.Add("Charlie");
            if (bool.Parse(d.ToString())) names.Add("David");
            string convicts = string.Join(", ", names);

            string result = "The crime was commited by: ";
            result += convicts + ".";
            return result;
        }
    }
}
