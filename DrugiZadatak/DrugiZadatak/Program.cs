using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            int ukupnoSekundi;
            int minute, sekunde;
            string time;
            Console.Write("Unesite sekunde: ");
            ukupnoSekundi = Convert.ToInt32(Console.ReadLine());
           
            sekunde = ukupnoSekundi % 60;
            minute = ukupnoSekundi / 60;
             time = minute + ":" + sekunde;
            Console.WriteLine(time);

            Console.ReadKey();
        }
    }
}
