/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/
class Program
{
    static void WriteArray(int[] array)
    {   
        Console.WriteLine("Вывод массива");
        for (int i=0;i<array.Length;i++)
        {
        Console.Write(array[i]+" ");
        }
        Console.WriteLine(" ");
    }
    static void Main(string[]args)
    {
        Console.WriteLine("Введите количество элементов массива");
        int N = Convert.ToInt32(Console.ReadLine());
        int[]array=new int[N];

        for (int i = 0; i < N; i++)
        {
        Console.WriteLine("Введите значение массива");
        string meaning=Console.ReadLine(); 
        int number=Convert.ToInt32(meaning);
        array[i]=number;
        }
    
    WriteArray(array);
    }
}

