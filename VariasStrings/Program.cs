using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Olá Mudo";
            string s2 = "\" Olalasdjaiefubvdirw mudo \"";
            string s3 = @"Olalasdjaiefubvdirw mudo";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}
