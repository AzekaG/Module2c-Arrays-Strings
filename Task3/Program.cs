using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
Из Википедии:
ДОМАШНЕЕ ЗАДАНИЕ
1
Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
символом, находящимся на некотором постоянном числе
позиций левее или правее него в алфавите. Например,
в шифре со сдвигом вправо на 3, A была бы заменена на
D, B станет E, и так далее.
Кроме механизма шифровки, реализуйте механизм
расшифрования.*/
namespace Task3
{
    internal class Program
    {
        public class CaesarCipher
        {
           
            string CifrerStr(int Key, string str)
            {
                
                char[] charRes = str.ToCharArray();
                for (int i = 0; i < charRes.Length; i++)
                {
                    charRes[i] = (char)(charRes[i] + Key);
                }
               
                string strRes = new string(charRes);
                return strRes;
            }
            string DeCifrerStr(int Key , string str)
            {
                char[] charRes = str.ToCharArray();
                for (int i = 0; i < charRes.Length; i++)
                {
                    charRes[i] = (char)(charRes[i] - Key);
                }

                string strRes = new string(charRes);
                return strRes;

            }


            static void Main(string[] args)
            {

                Console.WriteLine("Enter a string");
                string str = Console.ReadLine();
                Console.WriteLine("Enter a value for code (1-25)");
                int k = int.Parse(Console.ReadLine());

                CaesarCipher c = new CaesarCipher();
                Console.WriteLine(c.CifrerStr(k, str));
                Console.WriteLine(c.DeCifrerStr(k, c.CifrerStr(k, str)));

            }
        }
    }
}
