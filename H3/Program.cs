using System;
using static System.Net.Mime.MediaTypeNames;
//Homework #3
partial class Program
{
    static void Main(string[] args)
    {
        var task1Result = Task1();
        Console.Write($"{task1Result}\n");
        var task3Result = Task3();
        Console.Write($"{task3Result}\n");
        var task4Result = Task4();
        Console.Write($"{task4Result}\n");
        var task5Result = Task5();
        Console.Write($"{task5Result}\n");
        var task6Result = Task6();
        Console.Write($"{task6Result}\n");
        var task7result = Task7();
        Console.Write($"{task7result}\n");
        var task9result = Task9();
        Console.Write($"{task9result}\n");
    }
    static int Task1()
    {
        Console.WriteLine("Enter positive number: ");
        int number = Convert.ToInt16(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < number; i++)
        {
            result += i;
        }
        return result;
    }
    //static int Task2() // вывести таблицу умножения для 3, не понял как это сделать с помощью return
    //{
    //    int num = 3;
    //    int i = 1;
    //    int result;
    //    while (i < 11)
    //    {
    //        res = num * i;
    //        Console.WriteLine($"{num} * {i} = {result}\n");
    //        i++;
    //    }
    //}
    static int Task3()
    {
        int[] num = new int[] { 3, 5, 9, 8, 15 };
        int result = num[0] * num[1] * num[2] * num[3] * num[4];
        return result;
    }
    static int Task4()
    {
        int a = 2048;
        int b = 0;
        for (; a > 0; b++)
        {
            a /= 2;
            if (a < 10)
                break;
        }
        return b;
    }
    static string Task5()
    {
        string[] words = { "Aello", "Bello", "Mello", "lello", "Dello", "Cello" };
        string labas = "Labas!";
        string error = "This data array doesn't have Hello word";
        foreach (string word in words)
        {
            if (word == "Hello")
            {
                return labas;
            }
        }
        return error;
    }
    static int Task6()
    {
        int[] numbers = { 2, 5, 11, 94, 18 };
        int b = numbers[0] + numbers[4];
        return b;
    }
    static int Task7()
    {
        int[] numbers = { 5, 2, 30, 8, 1 };
        int result = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 1 | numbers[i] == 30)
                result += i;
        }
        return result;
    }
    //static int Task8() // Здесь также не понял как вывести резалт отсортированного массива через return 
    //{
    //    int[] num = { 8, 3, 10, 12, 64, 1 };
    //    int temp = 0;
    //    for (int write = 0; write < num.Length; write++)
    //    {
    //        for (int sort = 0; sort < num.Length - 1; sort++) 
    //        {
    //            if (num[sort] > num[sort + 1]) // если условие true, то свапаем местами индексы через переменную temp  
    //            {
    //                temp = num[sort + 1];
    //                num[sort + 1] = num[sort];
    //                num[sort] = temp;
    //            }
    //        }
    //    }
    //    for (int i = 0; i < num.Length; i++)
    //        Console.Write(num[i] + " "); // проходим циклом по каждому индексу и выводим отсортированный массив
    //}
    //static string Task9() // Также, как и с примеродесь надо вывести таблицу умножения от 1 до 10.
    //{
    //    int result = 0;
    //    string lol;
    //    for (int a = 1; a <= 10; a++)
    //    {
    //        for (int b = 1; b <= 10; b++)
    //        {
    //            result = a * b;
    //            Console.WriteLine($"{a} * {b} = {result}\n");
    //        }
    //    }
    //}
}
