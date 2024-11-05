using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_лаба_исключения
{

    public class IsLetter : Exception
    {
        public int LetterIndex { get; set; }
        public IsLetter() : base() { }
        public IsLetter(string message) : base(message) { }
        public IsLetter(string message, int letterIndex) : base(message)
        {
            LetterIndex = letterIndex;
        }
        public IsLetter(string message, Exception innerException) : base(message, innerException) { }
    }
    internal class Program
    {
        static void StringFill(ref string[] valueStr)
        {
            for (int i = 0; i < valueStr.Length; i++)
            {
                Console.WriteLine("введите {0}-й элемент массива", i + 1);
                valueStr[i] = Console.ReadLine(); ;
            }

        }
        static void StringPrint(string[] valueStr)
        {
            for (int i = 0; i < valueStr.Length; i++)
            {
                Console.Write(valueStr[i] + " ");
            }
            Console.WriteLine(); 
        }

        static int SumString(string[] valueStr)
        {
            int sum = 0;
            try
            {
                if (LetterInString(valueStr))
                {
                    for (int i = 0; i < valueStr.Length; i++)
                    {
                        sum += Convert.ToInt32(valueStr[i]);
                    }
                }

            }
            catch (IsLetter ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Ошибка в символе : {ex.LetterIndex + 1}");
            }
            return sum;
        }

        static bool LetterInString(string[] valueStr)
        {
            bool LetterInString = false;
            for (int i = 0; i < valueStr.Length; i++)
            {
                
                if (!valueStr[i].All(char.IsDigit))
                {
                    throw new IsLetter("Строка не конвертируется в числовое значение", i);
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размер массива");
            n = int.Parse(Console.ReadLine());

            string[] valueStr = new string[n];
            try
            {
                StringFill(ref valueStr);
                StringPrint(valueStr);
                LetterInString(valueStr);
                Console.WriteLine("Сумма числовых значений в строках : {0}", SumString(valueStr));
            }
            catch (IsLetter ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Ошибка в символе : {ex.LetterIndex+1}");
            }

            finally
            {
                Console.WriteLine("Программа закончилась");
            }
            Console.ReadKey();
        }
    }
}
