using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите количество элементов: ");
            string NText = Console.ReadLine();
            N = int.Parse(NText);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Начальная матрица");
            Console.WriteLine();
            Console.WriteLine();

            float[,] mas = new float[N, N];
            Random rand = new Random();
            float max = 0;
            int i_max = 0;
            int j_max = 0;
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    mas[i, j] = rand.Next(-10, 10);


                    if ((mas[i, j] > max))
                    {
                        max = mas[i, j];
                        i_max = i;
                        j_max = j;
                    }
                }
            }



            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    Console.Write("{0}\t", mas[i, j]);
                }

                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();





            mas[i_max, j_max] = mas[0, 0];
            mas[0, 0] = max;
            for (int count = 1; count < N; ++count)
            {
                max = mas[0, 1];
                for (int i = 0; i < N; ++i)
                    for (int j = 0; j < N; ++j)
                        if (((i != j) || ((i >= count) && (j >= count))) && (mas[i, j] > max))
                        {
                            max = mas[i, j];
                            i_max = i;
                            j_max = j;
                        }
                mas[i_max, j_max] = mas[count, count];
                mas[count, count] = max;
            }



            Console.WriteLine("Преобразованная матрица \n");

            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    Console.Write("{0}\t", mas[i, j]);

                }
                Console.WriteLine();

            }

            Console.WriteLine();


            for (int i = 0; i < N; ++i)
            {
                int count = 0;
                for (int j = 0; j < N; ++j)
                    if (mas[i, j] < 0)
                        ++count;
                if (count == N)
                {
                    Console.WriteLine("Строка ", i + 1, " не имеет положительных значений \n");


                }
            }

            Console.ReadKey();
        }
    }
}
