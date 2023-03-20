using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Пользователь с клавиатуры вводит некоторый текст.
Приложение должно изменять регистр первой буквы
каждого предложения на букву в верхнем регистре*/

namespace Task6
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text : ");
            string str = Console.ReadLine();
            TextInfo txt  = new CultureInfo("en-US", false).TextInfo;
            str = txt.ToTitleCase(str);
            Console.WriteLine(str);



        }
    }
}
