using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4zadanie
{
    internal class Program
    {
        public string[] SplitLine(string line)
        {
            string[] subs = line.Split(' ');
            return subs;
        }
        
        public void PrintLines(string[] words)
        {
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение с пробелом после каждого слова");
            string line = Console.ReadLine();
            Program program = new Program();
            string[] subs = program.SplitLine(line);
            program.PrintLines(subs);
        }
    }
}