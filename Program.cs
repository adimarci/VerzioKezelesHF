using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("adja meg a hosszat");
            int bekertSzamok = int.Parse(Console.ReadLine());
            int[] szamok = new int[bekertSzamok];
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Adjon meg a"+i+". számot");
                szamok[i] =int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int avg = 0;
            int max = 0;
           // max = Math.Max(szamok[]);
            foreach (int f  in szamok)
            {
                
                sum += f;
                
            }
            avg = sum / szamok.Length;
            Console.WriteLine(avg);
            

            Console.ReadKey();
        
        }
    }
}
