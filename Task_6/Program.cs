namespace Task_6;
//Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN.
//Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
//Магическим квадратом называется матрица,
//сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите размерность");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];
        int [] magic = new int[n + n + 2]; 
       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Введите число");
                array[i, j] = Convert.ToInt32(Console.ReadLine());

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

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                magic [i] += array [i,j]; //поиск сумм элементов всех строк и столбцов
                magic [n + i] += array [j,i];
            }

        for (int i = 0; i < n; i++)
        {
            magic[n + n] += array[i,i]; //поиск сумм элементов главной и побочной диагонали
            magic[n + n + 1] += array[i,n - 1 - i];
        }

        Console.WriteLine("Суммы элементов");
        for (int i = 0; i < (n + n + 2); i++)
        {
            Console.WriteLine("{0} ", magic[i]);
        } 
     

        int yes = 0; 
       
        for (int i = 0; i < (n + n + 2); i++)
            if (magic[i] == magic[n + n + 1])
                yes++;
            

        if (yes == n+n+2)
            Console.WriteLine("Данная матрица является магическим квадратом!");
        else
            Console.WriteLine("Данная матрица не является магическим квадратом!");

        Console.ReadKey();
    }
}

