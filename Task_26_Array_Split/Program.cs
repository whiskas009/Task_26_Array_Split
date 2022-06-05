using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_26_Array_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            string[] wordInPhrase = phrase.Split(' ');

            foreach (string word in wordInPhrase)
                Console.WriteLine(word);
        }
    }
}