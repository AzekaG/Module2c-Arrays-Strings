using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте приложение, проверяющее текст на недо-
пустимые слова. Если недопустимое слово найдено, оно
должно быть заменено на набор символов *. По итогам
работы приложения необходимо показать статистику
действий.*/

namespace Task7
{
    internal class Program
    {
        class RedactorCensoir
        {
            public string Censoir(string text , string wordTaboo)
            {
                string substring = "";
                for (int i = 0; i < wordTaboo.Length; i++)
                    substring += "*";
                int index;
                while (text.IndexOf(wordTaboo) > 0)
                {
                    index = text.IndexOf(wordTaboo);
                    text = text.Remove(index, wordTaboo.Length-1);
                    text = text.Insert(index, substring);
                }

                return text;
            }


        }
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter a text : ");

            string str = "To be, or not to be, that is the question,\r\n" +
                "Whether 'tis nobler in the mind to suffer\r\n" +
                "The slings and arrows of outrageous fortune,\r\n" +
                "Or to take arms against a sea of troubles,\r\n" +
                "And by opposing end them? To die: to sleep;\r\n" +
                "No more; and by a sleep to say we end\r\n" +
                "The heart-ache and the thousand natural shocks\r\n" +
                "That flesh is heir to, 'tis a consummation\r\n" +
                "Devoutly to be wish'd. To die, to sleep";

            RedactorCensoir red = new RedactorCensoir();
            str = red.Censoir(str, "die");
            Console.WriteLine(str);
                }
    }
}
