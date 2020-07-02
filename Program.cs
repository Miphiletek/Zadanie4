using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Бросаются две игральные кости. Определить вероятность того, что: а) сумма числа очков не превосходит N" +
                " Б)Произведение числа очков не превосходит N" +
                "В)Произведение числа очков делится на N,где N=8 "
                ) ;


            Console.WriteLine("Введите максимальное количество очков на кубике");
            int gran = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество кубиков");
            int kolvo = Convert.ToInt32(Console.ReadLine());

            int N = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите N");
                    N = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    continue;
                }
            }
            double P = 0;

            
            int[,] massivA = new int[gran, gran];


            
            int n = 0; 
            int m = 0;  

            for (int i = 1; i <= massivA.GetLength(1); i++)
            {
                for (int j = 1; j <= massivA.GetLength(0); j++)
                {
                    massivA[i - 1, j - 1] = i + j;
                    n++;

                    if (massivA[i - 1, j - 1] <= N)
                    {
                        m++;
                    }
                }
            }

            P = (double)m / n;

            Console.WriteLine("\n Матрица возможных вариантов");

            // выведем  - для наглядности 

            for (int i = 0; i < massivA.GetLength(1); i++)
            {
                for (int j = 0; j < massivA.GetLength(0); j++)
                {
                    Console.Write(massivA[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("n= " + n);

            Console.WriteLine("m= " + m + "\n");
            for (int i = 1; i <= massivA.GetLength(1); i++)
            {
                for (int j = 1; j <= massivA.GetLength(0); j++)
                {
                    massivA[i - 1, j - 1] = i * j;
                    n++;

                    if (massivA[i - 1, j - 1] <= N)
                    {
                        m++;
                    }
                }
            }
           double S = (double)m / n;
            for (int i = 1; i <= massivA.GetLength(1); i++)
            {
                for (int j = 1; j <= massivA.GetLength(0); j++)
                {
                    massivA[i - 1, j - 1] = (i * j)/N;
                    n++;

                    if (massivA[i - 1, j - 1] <= N)
                    {
                        m++;
                    }
                }
            }
            double F = (double)m / n;


            Console.WriteLine("вероятность выпадения  суммы числа очков " +
                "которые  не превосходит " + N + " = " + Math.Round(P, 4) * 100 + "%");
            Console.WriteLine("вероятность выпадения   числа очков произведение  " +
                "которых  не превосходит " + N + " = " + Math.Round(S, 4) * 100 + "%");
            Console.WriteLine("Введите N для проверки на вероятность выпадения числа которое делится на него ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("вероятность выпадения   числа очков произведение  " +
                "которых  делится на  " + N2 + " = " + Math.Round(F, 4) * 100 + "%");






        }
    }
}
