using System;
/* 
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да 
*/

string AskNumber()
{
    Console.Write("Введите ваше число: ");
    string number = Console.ReadLine();
    return number;
}


int ReverseNumber(int n)
{
    int temp = n;
    int reversed = 0;
    while (n > 0)
    {
        // остаток от деления на 10
        int digit = n % 10;
        reversed = reversed * 10 + digit;
        // целочисленное деление на 10
        n = n / 10;
    }
    return reversed;
}

void task19()
{
    Console.WriteLine("*Задача 19. Проверка на палиндром*");
    int n = Convert.ToInt32(AskNumber());
    int a = ReverseNumber(n);
    if (n == a)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int[] AskCoordinate()
{
    int[] coordinates = new int[3];
    int ctr = 0;
    int temp = 0;
    while (ctr < 3)
    {
        Console.WriteLine("введите координату");
        coordinates[ctr] = Convert.ToInt32(Console.ReadLine());
        ctr++;
    }
    return coordinates;
}

double GetDistance(int[] a, int[] b)
{
    double distance = Math.Sqrt(Math.Pow((a[0] - b[0]), 2) + Math.Pow((a[1] - b[1]), 2) + Math.Pow((a[2] - b[2]), 2));
    return distance;
}


void task21()
{
    Console.WriteLine("*Задача 21. Расстояние между 2 точками по 3 координатам*");
    Console.WriteLine("Первая точка");
    int [] PointA = AskCoordinate();
    Console.WriteLine("Вторая точка");
    int [] PointB = AskCoordinate();
    Console.WriteLine(GetDistance(PointA, PointB));
}


/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/

void PrintPower3(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

void task23()
{
    Console.WriteLine("*Задача 23. Вывод кубов*");
    int n = Convert.ToInt32(AskNumber());
    PrintPower3(n);
}

/*
Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
3, 5 -> 243
2, 4 -> 16
*/

void task25()
{
    Console.WriteLine("*Задача 25. Возведение в степень через цикл*");
    int a = Convert.ToInt32(AskNumber());
    int b = Convert.ToInt32(AskNumber());
    int ctr = 1;
    int temp = 1;
    if (b == 0)
    {
        Console.WriteLine("1");
    }
    else 
    {
        while (ctr <= b)
        {
            temp = a * temp;
            ctr++;
        }
        Console.WriteLine(temp);
    }
}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int[] String2Array(string number)
{
    int stringLength = number.Length;
    if (stringLength > 0)
    {
        int[] stringAsArray = new int[stringLength];
        for (int i = 0; i < stringLength; i++)
        {
            stringAsArray[i] = Convert.ToInt32(Char.GetNumericValue(number[i]));
        }
        return stringAsArray;
    }
    else
    {
        int[] stringAsArray = new int[0];
        return stringAsArray;
    }
}

void task27()
{
    Console.WriteLine("*Задача 27. Сумма цифр в числе*");
    int[] stringAsArray = String2Array(AskNumber());
    Console.WriteLine(stringAsArray.Sum());

}


/*
Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33]
*/

int[] CreateRandomIntArray(int n)
{
    int[] randomArray = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        randomArray[i] = rnd.Next(-10, 11);
    }
    return randomArray;
}

int[] ApplyAbsToArray(int[] arrayToAbs)
{
    int n = arrayToAbs.Length;
    int[] AbsArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        AbsArray[i] = Math.Abs(arrayToAbs[i]);
    }
    return AbsArray;
}

void PrintArray(int[] arrayToPrint)
{
    int n = arrayToPrint.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write(arrayToPrint[i]);
        Console.Write(" ");
    }

}

void task29()
{
    Console.WriteLine("*Задача 29. Вывод массива отсортированного по модулю*");
    int[] a = CreateRandomIntArray(8);
    PrintArray(a);
    Console.WriteLine();
    int[] b = ApplyAbsToArray(a);
    Array.Sort(b);
    PrintArray(b);
}

//task19();
//task21();
//task23();

task25();
task27();
task29();

