/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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

void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine("Вывод массива на печать...");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i] + "\t");
    }
    Console.WriteLine();

}
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

/*
*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива*
*/
double GetMax(double[] anArray)
    {
        double maxVal = anArray[0];
        for (int i = 0; i < anArray.Length; i++)
        {
            double thisNum = anArray[i];
            if (thisNum >= maxVal)
            {
                maxVal = thisNum;
            }
        }
        return maxVal;
    }

double GetMin(double[] anArray)
    {
        double minVal = anArray[0];
        for (int i = 0; i < anArray.Length; i++)
        {
            double thisNum = anArray[i];
            if (thisNum <= minVal)
            {
                minVal = thisNum;
            }
        }
        return minVal;
    }

double[] CreateRandomDoubleArray(int n)
{
    double[] randomArray = new double[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        randomArray[i] = rnd.NextDouble();
    }
    return randomArray;
}

void PrintDoubleArray(double[] arrayToPrint)
{
    int n = arrayToPrint.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write(arrayToPrint[i]);
        Console.Write(" ");
    }
    Console.WriteLine();

}

void task38()
{
    Console.WriteLine("*Задача 38. Разница между макс и мин в массиве*");
    int n = 5;
    double [] a = CreateRandomDoubleArray(n);
    Console.WriteLine("Исходный массив");
    PrintDoubleArray(a);
    double maxVal = GetMax(a);
    double minVal = GetMin(a);
    Console.Write("макс в массиве: ");
    Console.WriteLine(maxVal);
    Console.Write("мин в массиве: ");
    Console.WriteLine(minVal);
    Console.Write("Разница между макс и мин в массиве: ");
    Console.WriteLine(maxVal - minVal);
}

//task34();
//task36();
//task38();

/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

void task41()
{
    Console.WriteLine("*Задача 41. Число положительных в массиве*");
    Console.Write("Введите число элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int ctr = 0;
    int[] userArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        userArray[i] = Convert.ToInt32(Console.ReadLine());
        if (userArray[i] > 0) ctr++;
    }
    Console.WriteLine("Введенный массив:");
    PrintArray(userArray);
    Console.WriteLine("Положительных элементов: " + ctr);
}

/*
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/

double[] GetLineParameters()
{
    double[] lineKB = new double[2];
    Console.Write("Введите коэффициент k прямой: ");
    lineKB[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите коэффициент b прямой: ");
    lineKB[1] = Convert.ToDouble(Console.ReadLine());
    return lineKB;
}

void task43()
{
    Console.WriteLine("*Задача 43. Координаты пересечения прямых*");
    Console.WriteLine("Первая прямая");
    double[] lineFirst = GetLineParameters();
    Console.WriteLine("Вторая прямая");
    double[] lineSecond = GetLineParameters();
    double xCross = (lineSecond[1] - lineFirst[1]) / (lineFirst[0] - lineSecond[0]);
    double yCross = lineFirst[0] * xCross + lineFirst[1];
    Console.WriteLine($"Точка пересечения: ({xCross}, {yCross})");
}

task41();
task43();
