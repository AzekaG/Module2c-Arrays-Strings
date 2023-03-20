using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
Определить сумму элементов массива, расположенных
между минимальным и максимальным элементами.*/
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RND= new Random();
            int[,] Arr = new int[5, 5];
           for(int i = 0; i < 5;i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    Arr[i, j] = RND.Next(-100, 100);
                    Console.Write(Arr[i, j] + " ");
                }
                Console.WriteLine();
                
                    
            }

            int xMax=0, yMax=0, xMin=0, yMin=0;

            int max = Arr[0,0];
            int min = Arr[0,0];
            for (int i = 0;i < 5;i++) //в поисках индекса минимального елемента
            {
                for(int j = 0;j < 5;j++)
                {
                    if(Arr[i,j] > max ) 
                    {
                        max = Arr[i, j];
                        xMax = i;
                        yMax = j; 
                    }
                    if(Arr[i, j] < min) 
                    {
                        min = Arr[i, j];
                        xMin = i;
                        yMin = j; 
                    }
                }
            }
           int summAllElements = 0;
            if (xMin >= xMax || (xMin == xMax && yMin>yMax))
            {
                int temp = xMin;
                xMin = xMax;
                xMax = temp;
                temp = yMin;
                yMin = yMax;
                yMax= temp;
             }
            if(xMin==xMax && yMin==yMax) { summAllElements = Arr[xMin, xMax]; }
            else
            {
               for( int i = xMin;i<=xMax;i++)       //суммируем диапазон
                {
                    int j = 0;
                    if (i == xMin)
                    { j = yMin; };
                    for (; j<5; j++)
                    {
                        if (i >= xMax && j >= yMax)
                        {
                            summAllElements += Arr[i, j]; break;
                        };
                       summAllElements+= Arr[i, j];
                    }
                }
            }
            Console.WriteLine("1 Element : " + Arr[xMin, yMin]);
            Console.WriteLine("2 Element : " + Arr[xMax, yMax]);
            Console.WriteLine("SummElements = " + summAllElements);



        }
    }
}
