using System;

namespace ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Testers
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //byte age = 19;
            //bool test = true;
            //if (age >= 18)
            //{
            //    Console.WriteLine("Вам можно работать");
            //}
            //else
            //{
            //    Console.WriteLine("Вам лучше учиться");
            //}

            //switch (age)
            //{
            //    case 14:
            //        Console.WriteLine("Вы не молодец");
            //        break;

            //        case 19:
            //        Console.WriteLine("Вы молодец");
            //        break;

            //    default:
            //        break;
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("[ ]");
            //}
            //Console.WriteLine("Введите число от 1 до 10");
            //string answer = Console.ReadLine();

            //bool success = int.TryParse(answer, out int value);

            //if (value >= 1 && value <= 10)
            //{
            //    Console.WriteLine("Вы ввели: " + value);
            //}
            //bool success = false;
            //Console.WriteLine("Введите число от 1 до 10");
            //do
            //{

            //    string answer = Console.ReadLine();

            //    success = int.TryParse(answer, out int value);

            //    if (value >= 1 && value <= 10)
            //    {
            //        Console.WriteLine("Вы ввели: " + value);
            //    }

            //    if (!success)
            //    {
            //        Console.WriteLine("Вы ввели не число");
            //    }


            //} while (!success);

           // string name = "Ivan";
           // string nam1 = "Maks K";
           // string name2 = "Alex";
           // string name3 = "Artem";


           // string[] names = new string[13];

           // names[0] = "Ivan";
           // names[1] = "Alex";
           // names[2] = "Anime";

           //for (int i = 0; i < names.Length; i++)
           // {
           //     Console.WriteLine(names[i]);
           // }

            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next();
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }


    }

}