using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5_pererah
{
    internal class Program
    {
        [Flags]
        enum Software
        {
            None = 0b00000000,
            Google_Chrome=0b00000001,
            Safari=0b00000010,
            Edge=0b00000100,
            Opera=0b00001000,
            Visual_Studio=0b00010000,
            IntelliJ_Idea = 0b00100000,
            PyCharm = 0b01000000,
            XCode = 0b10000000,
            Microsoft=0b00010100,
            Apple=0b10000010,
            JetBrains=0b01100000,
            Google_LLC=0b100000001,
            Opera_Software= 0b100001000
        }
        static void Main(string[] args)
        {
            int aut=0;
            Console.WriteLine("   Варiант 7");
            Console.WriteLine("1. Google Chrome\n2. Safari\n3. Edge\n4. Opera\n5. Visual Studio\n6. IntelliJ Idea\n7. PyCharm\n8. XCode\n\n Оберiть номери програмних продуктiв: ");
                More:
            string[] N = Console.ReadLine().Split(',');
            foreach (var n in N)
                {
                 aut = Convert.ToInt16(n);
                 int prod = (int)Math.Pow(2, aut - 1);
                 if(aut>=1 && aut <= 8) {
                  Console.Write("\nПродукт - " + (Software)prod + "\nАвтор програми - ");
                  if (((Software)prod & Software.Google_LLC) != 0) { Console.Write(Software.Google_LLC + "\n"); }
                  else if (((Software)prod & Software.Apple) != 0) { Console.Write(Software.Apple + "\n"); }
                  else if (((Software)prod & Software.Microsoft) != 0) { Console.Write(Software.Microsoft + "\n"); }
                  else if (((Software)prod & Software.Opera_Software) != 0) { Console.Write(Software.Opera_Software + "\n"); }
                  else if (((Software)prod & Software.JetBrains) != 0) { Console.Write(Software.JetBrains + "\n"); }                        
                 }
                 else { Console.WriteLine("\nВи помилилися, спробуйте ще раз: "); goto More; }
            }
            Console.ReadLine();
        }
    }
}
