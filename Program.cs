using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            /*  Получаем размер  матрицы от пользователя */
            int n = Convert.ToInt32(Console.ReadLine());
            /*  
             

             Делаем матрицу квдртатной 

                        или

             int n = Convert.ToInt32(Console.ReadLine());
             
             */
            int m = n;
            /*  Cоздаём двухмерный массив и заполняем его */
            string[,] mas = new string[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (i == j)
                    {
                        mas[i, j] = "1";

                    }

                }
            }
            /*  Форматированный вывод этой матрицы */

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
/*  Для вывода и/или заполнения матрицы необходимо проводить итерацию циклом по каждому её элементу, обращаясь к индексам этих элементов */
