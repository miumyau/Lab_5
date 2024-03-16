using System;

namespace Task_5;
//Запросить у пользователя целочисленное значение N.
//Сформировать двумерный массив размера NxN следующего вида:

//1 0 1 0 1

//0 1 0 1 0

//1 0 1 0 1


//0 1 0 1 0

//1 0 1 0 1
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размерность");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];

        Console.WriteLine(n);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
            
                
                if (i == j)
                {
                    array[i, j] = 1;
                    

                }

                if (i + j == n-1)
                {
                    array[i, j] = 1;
              

                }

                if ((i + j) % 2 == 0)
                {
                    array[i, j] = 1;
                    

                }

                else
                {
                    array[i, j] = 0;
                    
                }
            }
            
           
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

                Console.Write("{0,4} ", array[i, j]);


            }


            Console.WriteLine();

        }
        Console.ReadKey();
    }
        
    }


