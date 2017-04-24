using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChaseKata2
{
    /*
     Programming Challenge Description:
    A subsequence of a given sequence S consists of S with zero or more elements deleted.
    Formally, a sequence Z = z1z2..zk is a subsequence of X = x1x2...xm, 
    if there exists a strictly increasing sequence of indices (i) of X 
    such that for all j=1,2,...k we have Xi = Zj. E.g. Z=bcdb is a subsequence of X=abcbdab
    with corresponding index sequence <2,3,5,7>

    Input:
    Your program should read lines from standard input. Each line contains two comma separated strings.
    The first is the sequence X and the second is the subsequence Z.

        input -- babgbag,bag
                 rabbbit,rabbit
    Output:
    Print out the number of distinct occurrences of Z in X as a subsequence.
       output -- 5
                 3
    */
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] sArray = line.Split(',');
                    string str = sArray[0];
                    string pattern = sArray[1];
                    int count = -1;

                    for (int i = pattern.Length; i > 0; i--)
                    {
                        if (pattern != "")
                        {
                            count += NumberOfMatches(str, pattern);
                            pattern = pattern.Substring(0, pattern.Length - 1);
                            //str = str.Replace(pattern, "");
                        }

                    }
                    Console.WriteLine(count);
                }
        }

        static int NumberOfMatches(string str, string pattern)
        {
            string s2 = str.Replace(pattern, "");
            return (str.Length - s2.Length) / pattern.Length;

        }

    }
}
