using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4_5__radki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше слово рядка: ");
            string word1 = Console.ReadLine()+ " ";
            Console.WriteLine("Введiть друге слово рядка: ");
            string word2 = Console.ReadLine();
            string radok= string.Concat(word1, word2);
            Console.Write("Отриманий рядок: "+ radok+ "\nЛiтери, якi зустрiчаються в обох словах лише один раз: ");
            for(int i=0; i<radok.Length; i++) 
            {
                if (radok.IndexOf(radok[i]) == radok.LastIndexOf(radok[i]) && i != word1.Length - 1) 
                { 
                    Console.Write(radok.Substring(i, 1)+ " ");
                };
            };
            Console.ReadLine();
        }
    }
}
