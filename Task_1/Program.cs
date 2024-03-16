namespace Task_1;
//Сформировать одномерный массив из 7 элементов. Заполнить массив числами,
//вводимыми с клавиатуры, определить среднее арифметическое элементов.
class Program
{
    static void Main(string[] args)
    {
        double [] array = new double[7];
        double S = 0;
        int n=0;
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Введите число");
            array[i] = Convert.ToDouble(Console.ReadLine());
            S += array[i];
            n++;
        }
        double S1 = S/n;
        Console.WriteLine("среднее арифметическое элементов {0:f2}", S1);
        Console.ReadKey();

    }
}

