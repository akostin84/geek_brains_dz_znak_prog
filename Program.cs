﻿string AskNumber()
{
    Console.Write("Введите ваше число: ");
    string number = Console.ReadLine();
    return number;
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

int[] CreateRandomIntArray(int n, int lowerBound, int upperBound)
{
    int[] randomArray = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        randomArray[i] = rnd.Next(lowerBound, upperBound);
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
    Console.WriteLine();

}

void task29()
{
    Console.WriteLine("*Задача 29. Вывод массива отсортированного по модулю*");
    int[] a = CreateRandomIntArray(8, -11, 10);
    PrintArray(a);
    Console.WriteLine();
    int[] b = ApplyAbsToArray(a);
    Array.Sort(b);
    PrintArray(b);
}

/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

bool isEven(int n)
{
    if(n % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void task34()
{
    Console.WriteLine("*Задача 34. Подсчет четных в массиве*");
    int n = 20;
    int[] a = CreateRandomIntArray(n, 100, 1000);
    Console.WriteLine("Исходный массив");
    PrintArray(a);
    Console.Write("Количество четных в массиве: ");
    int ctr = 0;
    for (int i = 0; i < n; i++)
    {
        if (isEven(a[i]))
        {
            ctr++;
        };
    }
    Console.WriteLine(ctr);

}

/*
*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*
*/
void task36()
{
    Console.WriteLine("*Задача 36. Сумма элементов на нечетных позициях*");
    int n = 5;
    int[] a = CreateRandomIntArray(n, 0, 10);
    Console.WriteLine("Исходный массив");
    PrintArray(a);
    Console.Write("Сумма по нечетным позициям в массиве: ");
    int ctr = 0;
    for (int i = 0; i < n; i++)
    {
        if (!isEven(i + 1))
        {
            ctr = ctr + a[i];
        };
    }
    Console.WriteLine(ctr);

}

task34();
task36();
