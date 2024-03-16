namespace Task_2;
//Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
//Определить сумму максимального и минимального элементов массива.
class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[15];
        Random random = new Random();
        int max;
        int min;

        for (int i = 0; i < 15; i++)
        {
            array[i] = random.Next(0, 50);
            Console.Write("{0} ", array[i]);
        }

        max = array[0];
        min = array[0];
        foreach (int a in array)
        {
            if (a > max)
            {
                max = a;
            }

            if (a < min)
            {
                min = a;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Сумма минимального и максимального элементов равна {0}", max+min);
        Console.ReadKey();
    }
}

