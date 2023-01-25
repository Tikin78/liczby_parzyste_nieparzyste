using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbaParzystaNieparzysta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą a ja powiem Ci czy liczba jest parzysta czy nieparzysta");

            var liczba = GetLiczba();
            
            //var liczba = int.Parse(Console.ReadLine());
            
            while(true) 
            {
                if((liczba % 2)==0) 
                {
                    Console.WriteLine("Liczba parzysta");
                    break;
                }
                else 
                {
                    Console.WriteLine("Liczba nieparzysta");
                    break;
                
                }
            
            }

        }

        private static int GetLiczba()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int liczba))
                    
                {
                    Console.WriteLine("Podałeś nie prawidłowe dane. Spróbój ponownie.");
                    continue;
                }
                return liczba;
            }
        }
    }
}
