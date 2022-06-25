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
    int n = arrayToPrint.Length;
    for (int i = 0; i < n; i++)
    {
        Console.Write(arrayToPrint[i]);
        Console.Write(" ");
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

task34();
task36();
task38();
