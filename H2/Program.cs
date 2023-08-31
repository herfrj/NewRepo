//Homework #2
partial class Program
{
    static void Main(string[] args)
    {
        var task1Result = Task1();
        Console.Write($"Variable: {task1Result}\n");
        var task2Result = Task2();
        Console.Write($"{task2Result}\n");
        var task3Result = Task3();
        Console.Write($"n + n * 2 = {task3Result}\n");
        var task4Result = Task4();
        Console.Write($"{task4Result}\n");
        var task5Result = Task5();
        Console.Write($"{task5Result}\n");
        var task6Result = Task6();
        Console.Write($"{task6Result}\n");
        var task7Result = Task7();
        Console.Write($"{task7Result}\n");
        var task8Result = Task8();
        Console.Write($"{task8Result}\n");
        var task9Result = Task9();
        Console.Write($"{task9Result}\n");
    }
    static byte Task1()
    {
        byte var;
        byte num = 20;
        var = num += 5;
        return var;
    }
    static string Task2() // не дошло до меня как сделать через анонимный метод
    {
        Console.Write("Enter four-digit number: ");
        int InsertedDay = Convert.ToInt16(Console.ReadLine());
        int DaysInYear = 365; // days in a year
        int DaysInMonth = 30; // days in a month
        int Year = InsertedDay / DaysInYear; // number of years  
        int Month = (InsertedDay % DaysInYear) / DaysInMonth; // number of months
        int Days = (InsertedDay % DaysInYear) % DaysInMonth; // number of days
        var result = $"{Year} years, {Month} month, {Days} days"; // result
        return result;
    }
    static int Task3()
    {
        Console.Write("Введите число n: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = number + number * 2;
        return result;
    }
    static string Task4()
    {
        sbyte a = -34;
        byte b = 4;
        string c = "Hello";
        char d = 'R';
        double e = 23.093433222;
        ushort f = 40000;
        bool g = true;
        byte h = 0;
        var result = $"{a} - sbyte, {b} - byte, {c} - string, {d} - char, {e} - double, {f} - ushort, {g} - bool, {h} - byte";
        return result;
    }

    static string Task5()
    {
        Console.Write("Enter short: ");
        short toShort = Convert.ToInt16(Console.ReadLine());
        Console.Write("Enter ulong: ");
        ulong toUlong = Convert.ToUInt64(Console.ReadLine());
        Console.Write("Enter char: ");
        char toChar = Convert.ToChar(Console.ReadLine());
        Console.Write("Enter double: ");
        double toDouble = Convert.ToDouble(Console.ReadLine());
        string result = "Done";
        return result;
    }
    static int Task6()
    {
        int a = -5;
        a *= 7;
        --a;
        return a;
    }

    static string Task7()
    {
        Console.WriteLine("Enter number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = a / 2;
        string temp;
        if (b * 2 == a)
        {
            temp = "Number is even";
        }
        else
        {
            temp = "Number is odd";
        }
        return temp;
    }
    static string Task8()
    {
        Console.WriteLine("Enter number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        string temp;
        if (a < 50 & a != 37 & a > 32 | a == 0 | a == 5)
            temp = "Working";
        else
        {
            temp = "not Working";
        }
        return temp;
    }
    static int Task9()
    {
        Console.WriteLine("Enter fist number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter symbol (+, -, *, /): ");
        char symbol = Convert.ToChar(Console.ReadLine());
        int result = 0;
        switch (symbol)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
        }
        return result;
    }
}

