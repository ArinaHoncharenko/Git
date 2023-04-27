using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_mas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задача 1. 0,1,2 сортування
            int i, k;
            int[] arr = new int[15];
            Random rand = new Random(3);
            Console.WriteLine("\t Задача 1. \n  Масив:");
            for (i = 0; i < 15; i++)
            {
                arr[i] = rand.Next(0, 3);
                Console.Write(arr[i]+" ");
            };
            int zmin1 = arr[0];
            for (i = 1; i < 15; i++)
            {
                for (k = 0; k < 14; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        zmin1 = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = zmin1;
                    }
                }
            };
            Console.WriteLine("\n\n Масив пiсля сортування: ");
            foreach (int h in arr) Console.Write(h + " ");
            System.Console.ReadLine();

                     //Задача 2. два способи сортування.
            Console.WriteLine("\n\tЗадача 2 \n  Масив 1:");
            int[] arr2 = new int[30];
            Random rand2 = new Random(100);
            for (i = 0; i < 30; i++)
            {
                arr2[i] = rand.Next(0, 100);
                Console.Write(arr2[i] + " ");
            }

            for (i = 1; i < 30; i++)
            {
              for (k = 0; k < 29; k++)
              {
                 if (arr2[k] > arr2[k + 1])
                 {
                    int zmin2 = arr2[0];
                    zmin2 = arr2[k];
                    arr2[k] = arr2[k + 1];
                    arr2[k + 1] = zmin2;
                 }
              }
            };
                Console.WriteLine("\n\n  Масив пiсля бульбашкового сортування: ");
            foreach (int h in arr2) Console.Write(h + " ");
            
            // метод вставок
            int zmin22;
            Console.WriteLine("\n\n  Масив 2:");
            int[] arr22 = new int[30];
            Random rand22 = new Random(100);

            for (i = 0; i < 30; i++)
            {
                arr22[i] = rand.Next(0, 100);
                Console.Write(arr22[i] + " ");
            }

            for (i = 0; i < 30; i++)
            {
                int key = arr22[i];
                int j = i;
                while ((j >= 1) && (arr22[j - 1] > key))
                {
                    zmin22 = arr22[j];
                    arr22[j] = arr22[j - 1];
                    arr22[j - 1] = zmin22;
                    j--;
                }
                arr22[j] = key;
            }
            Console.WriteLine("\n\n  Масив пiсля сортування вставками: ");
            foreach (int h in arr22) Console.Write(h + " ");
            Console.ReadLine();
            
        }

    }
}

