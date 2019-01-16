using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CitanjeTeksta
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader
                (
@"C:\Users\Učenik\Documents");
            // Čitamo datoteku liniju po liniju
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            // Zatvaramo datoteku
            sr.Close();
            Console.ReadKey();
        }
    }
}