using System;

namespace TestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //* 1.Используя Visual Studio, создайте проект по шаблону 
            //* Console Application.  Напишите программу определения, попадает 
            //* ли указанное пользователем число от 0 до 100 в числовой 
            //* промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. Если да, 
            //* то укажите, в какой именно промежуток. Если пользователь 
            //* указывает число, не входящее ни в один из имеющихся числовых 
            //* промежутков, то выводится соответствующее сообщение.

            string input;
            int num;
            Console.Write("Введите число: ");
            input = Console.ReadLine();
            num = int.Parse(input);

            if (num >= 0 && num <= 14)
            {
                Console.WriteLine($"Число {num} входит в промежуток [0 - 14]");
            }
            else if (num >= 15 && num <= 35)
            {
                Console.WriteLine($"Число {num} входит в промежуток [15 - 35]");
            }
            else if (num >= 36 && num <= 50)
            {
                Console.WriteLine($"Число {num} входит в промежуток [36 - 50]");
            }
            else if (num >= 50 && num <= 100)
            {
                Console.WriteLine($"Число {num} входит в промежуток [50 - 100]");
            }
            else
            {
                Console.WriteLine($"Число {num} не входит ни в один из указаных промежутков");
            }
        }
    }
}
