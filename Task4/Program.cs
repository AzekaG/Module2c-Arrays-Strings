using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
/*Создайте приложение, которое производит операции
над матрицами:
■■Умножение матрицы на число;
■■Сложение матриц;
■■Произведение матриц*/

namespace Task4
{
    internal class Program
    {
        class MatrixIni
            {
            public void MatrixIniRand(int[,] arr) 
            {
                Random rand = new Random();
                for(int i = 0; i < Math.Sqrt(arr.Length);i++)
                {
                    for (int j = 0; j < Math.Sqrt(arr.Length); j++)
                    {
                        arr[i,j]=rand.Next(20);
                    }
                }
            }
            };

        class MatrixMath
        {
           public void MatrixGeneration(int[,] Arr , int value)
            {
                for(int i = 0; i < Math.Sqrt(Arr.Length); i++) 
                {
                        for (int j = 0; j < Math.Sqrt(Arr.Length); j++) 
                            {
                        Arr[i, j] *=value ;
                            }
                }
                
            }      
            public void MatrixSumm(int[,] Arr1 , int[,] Arr2)
            {
                for (int i = 0; i < Math.Sqrt(Arr1.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(Arr1.Length); j++)
                    {
                        Arr1[i, j] += Arr2[i, j];
                    }
                }
            }
            public void MatrixProduct(int[,] Arr1, int[,] Arr2)
            {
                for (int i = 0; i < Math.Sqrt(Arr1.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(Arr1.Length); j++)
                    {
                        Arr1[i, j] *= Arr2[i, j];
                    }
                }
                
            }

        };

        static void Main(string[] args)
        {
            int[,] arr = new int[5,5];
            int[,] arr2 = new int[5, 5];
    
            MatrixIni matrixIni = new MatrixIni();  //инициализация
            matrixIni.MatrixIniRand(arr);
            matrixIni.MatrixIniRand(arr2);
            
            foreach (var i in arr) {Console.Write(i+" "); }
            Console.WriteLine();
    
            MatrixMath matrixMath = new MatrixMath();   //умножение
            matrixMath.MatrixProduct(arr, arr2);
            foreach (var i in arr) { Console.Write(i + " "); }

            Console.WriteLine();            //сумма
            matrixMath.MatrixSumm(arr, arr2);
            foreach(var i in arr) { Console.Write(i + " "); }

            Console.WriteLine();
            matrixMath.MatrixGeneration(arr, 2);        //умножение на число
            foreach(var i in arr) { Console.Write(i + " "); }
        }
    }
}
