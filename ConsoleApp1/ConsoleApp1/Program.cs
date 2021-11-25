using System;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            uint N;
            try
            {
                Console.Write("Введите количество элементов: ");
                string NText = Console.ReadLine();
                N = uint.Parse(NText);
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод");
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то не так\n" + e.Message);
                return;
            }


            Console.WriteLine();


            double[] mas = new double[N];
            Random rand = new Random();



            for (int i = 0; i < N; i++)
            {
                mas[i] = Math.Round((rand.NextDouble() * 10 - 5), 2);
            }


            for (int i = 0; i < N; i++)
            {
                Console.Write("{0,4} \t", mas[i]);
            }


            Console.WriteLine();
            Console.WriteLine();

            int count = 0;
            foreach (double K in mas)
            {
                if (K > 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Количество положительных элементов: " + count);



            Console.WriteLine();
            Console.WriteLine();


            int index = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] == 0 || mas[i] != 0)
                {
                    index = i;
                }

            }

            double sum = 0;
            for (int i = index; i < N; i++)
            {
                if ((mas[i] == 0))
                {
                    sum += mas[i];
                }
                if ((mas[i] != 0))
                {
                    Console.WriteLine("В данном массиве нет элементов со значением ноль");
                    Console.WriteLine("Значение суммы не может быть посчитано");
                }
            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Преобразованный массив");

            double[] mas2 = new double[N];

            int j = 0;

            for (int i = 0; i < N; i++)
            {


                if (Math.Truncate((mas[i])) <= 1)
                {
                    mas2[j] = mas[i];
                    j++;

                }



            }



            for (int i = 0; i < N; i++)
            {
                if (Math.Truncate((mas[i])) > 1)
                {
                    mas2[j] = mas[i];
                    j++;
                }
            }

            Console.WriteLine();


            for (j = 0; j < N; j++)
            {
                Console.Write("{0,4} \t", mas2[j]);
            }




        }


    }
}