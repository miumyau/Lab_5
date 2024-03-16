namespace Task_4;
//. Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
//Определить количество   нечетных положительных элементов, стоящих на четных местах.
class Program
{
    static void Main(string[] args)
    {
       int [] array = new int [20];

        Random random = new Random();

        int n = 0;

        for (int i = 0; i < 20; i++)
        {
            array[i] = random.Next(0, 50);
            Console.Write("{0} ", array[i]);
        }

        for (int i = 1; i < 20; i+=2)
        {
            if (array[i]>0 && array[i]%2!=0)
            {
                n++;
            }
        }

        Console.WriteLine();
        Console.WriteLine("количество   нечетных положительных элементов, стоящих на четных местах {0}",n);
    }
}

