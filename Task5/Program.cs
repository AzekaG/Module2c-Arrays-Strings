using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
/*Пользователь с клавиатуры вводит в строку ариф-
метическое выражение. Приложение должно посчитать
его результат. Необходимо поддерживать только две
операции: + и –.*/


namespace Task5
{
    internal class Program
    {
        class PrimitiveCalc
        {
            public int Operation(string str)
            {//идея заключается в том , что пока в строке есть по порядку числа-записываем в первую ячейку числового 
                //массива суммируя (используя умножение на 10 , если ето не 1-значное число
                //, если знак-записываем его в чаровский массив.
                //получается что в каждой ячейке числового аррэя у нас нужное число
                
                int[] arr = new int[str.Length];
                char[] arrAction = new char[str.Length];
                int countValue = 0;
                int temp = 0;
                int countAction = 0;
                for (int i = 0; i < str.Length; i++)
                {

                    if (((short)str[i]) >= '0' && ((short)str[i]) <= '9')      //логика читабельна
                    { arr[countValue] *=  (int)Math.Pow(10, temp);              
                       arr[countValue] +=str[i] - 48;
                        if (temp == 0) temp++;
                    }

                    else { arrAction[countAction++] = str[i];
                        temp = 0;
                        countValue++;
                    } 
                }
                int res = arr[0];
                countValue = 0;
                temp = 0;



                for (int i = 0; i <=countAction; i++) 
                {
                    if (arrAction[temp] == '+')
                    {
                        res += arr[++countValue];
                        ++temp;
                    }
                    if (arrAction[temp] == '-')
                    {
                        res -= arr[++countValue];
                        ++temp;
                    }
                }


                return res;
                }
              
            }
       static void Main(string[] args)
        {
            Console.WriteLine("Напишите выражение : ");
            string str = Console.ReadLine();

            PrimitiveCalc PC = new PrimitiveCalc();
            Console.WriteLine(PC.Operation(str));
            


        }
    }
}
