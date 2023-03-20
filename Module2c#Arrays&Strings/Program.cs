using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


/*Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив
А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов. Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы.  +
Найти в данных массивах 
-общий максимальный элемент,+
-минимальный элемент,+
-общую сумму всех элементов,+
-общее произведение всех элементов,+
-сумму четных элементов массива А +
-сумму нечетных столбцов массива В*/

namespace Module2c_Arrays_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            double[,] B = new double[3,5];
            Random a = new Random();
            for (int i = 0; i < A.Length; i++) 
            {
                A[i] = a.Next(0, 20);
                Console.Write(A[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("___________");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    B[i, j] = a.Next(20) + a.NextDouble();

                    Console.Write(Math.Round(B[i, j], 2) + "   ");
                }
                Console.WriteLine();
            }

            double maxElement =  (A.Max() > B.Cast<double>().Max()) ? A.Max() : B.Cast<double>().Max();       //говорится *общий максимальный елемент* ,
            Console.WriteLine("\"общий\" максимальный елемент  = "+ Math.Round(maxElement, 2));               //я понимаю из двух массивов найти максимум

            double minElement = (A.Min() < B.Cast<double>().Min()) ? A.Min() : B.Cast<double>().Min();
            Console.WriteLine("\"общий\" минимальный елемент  = " + Math.Round(minElement,2));         

            double summAllElements = A.Sum()+B.Cast<double>().Sum();
            Console.WriteLine("Сумма всех елементов = " + Math.Round(summAllElements, 2));  //сумма всех елементов

            double productAllElements = 1; 


            foreach (var i in A) 
            {
                productAllElements *= i;
            }
            foreach (var i in B)
            {
                productAllElements *= i;
            }   
            Console.WriteLine("Общее произведение : " + Math.Round(productAllElements,2) + "   немножко много для произведения)");

            int evenSummA = 0;
            foreach (var i in A) 
            {
                evenSummA = i % 2 == 0 ? evenSummA + i : evenSummA;
            }
            Console.WriteLine("Сумма четных чисел  в массиве А  : " + evenSummA);

            double noEvenSummB = 0;
            foreach(var i in B)
            { 
                noEvenSummB = i % 2 != 0 ? noEvenSummB + i : noEvenSummB;
            }
            Console.WriteLine("Сумма нечетных чисел в массиве B " + noEvenSummB + "  а так как у нас все дробные числа по определению неЧетные - это будет общая сумма елементов"); 

            
        }
    }
}
