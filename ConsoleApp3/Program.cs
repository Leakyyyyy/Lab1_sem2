using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskNet
{

    internal class Program
    {

        static void Degree(int number)
        {

            int tempNumber = 0;
            int degree = 0;

            Console.WriteLine("Введите степень этого числа:");
            degree = Convert.ToInt32(Console.ReadLine());

            tempNumber = number;

            for (int indexOfDegree = 1; indexOfDegree < degree; ++indexOfDegree)
            {
                number *= tempNumber;
            }

            Console.WriteLine("Число в этой степени = " + number + "\n");
            Console.WriteLine("Операция завершена. Нажмите любую кнопку для выхода");
            Console.ReadKey();
        }

        static void AddDigitToTheNumber(int number)
        {
            string stringNumber;
            char attachedDigit;
            if (number < 100)
            {
                Console.WriteLine("Слишком короткое число. Введите это чисо еще раз");
                number = Convert.ToInt32(Console.ReadLine());
                AddDigitToTheNumber(number);
            }
            else
            {
                stringNumber = number.ToString();
                attachedDigit = stringNumber[1];

                Console.WriteLine("Результат: " + stringNumber.Remove(1, 1) + attachedDigit);
                Console.WriteLine("Операция завершена. Нажмите любую кнопку для выхода");
                Console.ReadKey();
            }

        }

        static void Main(string[] args)
        {
            int mainNumber = 0;
            char selection = ' ';
            Console.WriteLine("Введите число: ");
            mainNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите операцию: \n");
            Console.WriteLine("d = степень этого числа \n");
            Console.WriteLine("a = 2 вторая цифра числа поствавленая в конце");
            selection = Convert.ToChar(Console.ReadLine());
            if (selection == 'd')
            {
                Degree(mainNumber);
            }
            else if (selection == 'a')
            {
                AddDigitToTheNumber(mainNumber);
            }
            else
            {
                Console.WriteLine("Неправильный тип операции. Нажмите любую кнопку для выхода");
                Console.ReadKey();
            }

        }

    }
}