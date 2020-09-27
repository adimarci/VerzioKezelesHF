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
            int sum = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine("Adjon meg a "+(i+1)+". számot");
                szamok[i] =int.Parse(Console.ReadLine());
                sum += szamok[i];
            }
            
            int avg = 0;
            int max = szamok.Max();
            int min = szamok.Min();

           
            avg = sum / szamok.Length;
            Console.WriteLine("Számok átlaga: "+avg+"\n Maximuma: "+max+"\n Minimuma :"+min);
            

            Console.ReadKey();
        
        }
    }
}
