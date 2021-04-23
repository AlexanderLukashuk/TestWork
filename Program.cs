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
            /*int num;
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
            }*/


            //* 2.Используя Visual Studio, создайте проект по шаблону 
            //*ConsoleApplication.  Напишите программу расчета начисления 
            //* премий сотрудникам. Премии рассчитываются согласно выслуге лет. 
            //* Если выслуга до 5 лет, премия составляет 10% от заработной платы.  
            //* Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 
            //* 15% от заработной платы.  Если выслуга от 10 лет (включительно) 
            //* до 15 лет, премия составляет 25% от заработной платы.  Если 
            //* выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% 
            //* от заработной платы.  Если выслуга от 20 лет (включительно) 
            //* до 25 лет, премия составляет 45% от заработной платы. Если 
            //* выслуга от 25 лет (включительно) и более, премия составляет 50% 
            //* от заработной платы.  Результаты расчета, выведите на экран.

            /*int salary;
            int seniority;
            double prize;
            int tmp;

            Console.Write("Введите зарплату: ");
            input = Console.ReadLine();
            salary = int.Parse(input);
            Console.Write("Введите сколько лет работаете: ");
            input = Console.ReadLine();
            tmp = int.Parse(input);
            if (tmp < 0)
            {
                while (tmp < 0)
                {
                    Console.WriteLine("Количество проработаных лет не может быть меньше 0");
                    Console.Write("Попробуйте ввести еще раз: ");
                    input = Console.ReadLine();
                    tmp = int.Parse(input);
                }
            }
            seniority = tmp;

            if (seniority >= 0 && seniority < 5)
            {
                prize = salary * 0.1;
                Console.WriteLine($"Премия при выслуге до 5 лет = {prize}");
            }
            else if (seniority >= 5 && seniority < 10)
            {
                prize = salary * 0.15;
                Console.WriteLine($"Премия при выслуге от 5 лет до 10 лет = {prize}");
            }
            else if (seniority >= 10 && seniority < 15)
            {
                prize = salary * 0.25;
                Console.WriteLine($"Премия при выслуге от 10 лет до 15 лет = {prize}");
            }
            else if (seniority >= 15 && seniority < 20)
            {
                prize = salary * 0.35;
                Console.WriteLine($"Премия при выслуге от 15 лет до 20 лет = {prize}");
            }
            else if (seniority >= 20 && seniority < 25)
            {
                prize = salary * 0.45;
                Console.WriteLine($"Премия при выслуге от 20 лет до 25 лет = {prize}");
            }
            else
            {
                prize = salary * 0.5;
                Console.WriteLine($"Премия при выслуге более 25 лет = {prize}");
            }*/


            //* 3.Дана следующая функция y = f(x):
            //* y = 2x - 10, если x > 0
            //* y = 0, если x = 0
            //* y = 2 * |x| -1, если x < 0

            /*double x;
            double y;
            Console.Write("Введите x: ");
            input = Console.ReadLine();
            x = double.Parse(input);

            if (x > 0)
            {
                y = 2 * x - 10;
                Console.WriteLine($"y = {y}");
            }
            else if (x == 0)
            {
                y = 0;
                Console.WriteLine($"y = {y}");
            }
            else if (x < 0)
            {
                y = 2 * Math.Abs(x) - 1;
                Console.WriteLine($"y = {y}");
            }*/

            //* 4.Дано два числа A и B (A<B) выведите все нечетные значения, 
            //* расположенные между данными числами.

            int A = 0;
            int B = 0;
            int tmpA;
            int tmpB;
            Console.WriteLine("Введите A и B(A < B)");
            Console.Write("Введите A: ");
            input = Console.ReadLine();
            tmpA = int.Parse(input);
            Console.Write("Введите B: ");
            input = Console.ReadLine();
            tmpB = int.Parse(input);

            if (tmpA > tmpB)
            {
                while (tmpA > tmpB)
                {
                    Console.WriteLine("A должно быть меньше B");
                    Console.Write("Введите A: ");
                    input = Console.ReadLine();
                    tmpA = int.Parse(input);
                    Console.Write("Введите B: ");
                    input = Console.ReadLine();
                    tmpB = int.Parse(input);
                }
            }
            A = tmpA;
            B = tmpB;

            for (int i = A; i < B; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();


            //* 5.Используя Visual Studio, создайте проект по шаблону 
            //* ConsoleApplication.  Создайте массив размерностью в 10 
            //* элементов, выведите на экран все элементы массива в обратном 
            //* порядке и найти среднее арифметическое ряда значений.
        }
    }
}
