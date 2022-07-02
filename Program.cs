void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine("Вывод массива на печать...");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i] + "\t");
    }
    Console.WriteLine();

}

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

/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] FillArray(int rows, int columns)
{
    double[,] randomArray = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows ; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            randomArray[i, j] = rand.NextDouble() * 10 - 5;
        }
    }
    return randomArray;
}

void PrintMatrix(double[,] matrixToPrint)
{
    Console.WriteLine("Вывод двумерного массива на печать...");
    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToPrint.GetLength(1); j++)
        {
            Console.Write(matrixToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void task47()
{
    Console.WriteLine("*Задача 47. Задание двумерного массива действительных чисел");
    Console.Write("Введите число строк массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите число столбцов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    double[,] randMatrix = FillArray(n, m);
    PrintMatrix(randMatrix);
}

/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
*/

void task50()
{
    Console.WriteLine("*Задача 50. Вывод элемента массива по позиции");
    Console.Write("Введите номер строки массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    double[,] randMatrix = FillArray(10, 10);
    if (n <= randMatrix.GetLength(0) && m <= randMatrix.GetLength(1) && n >= 0 && m >= 0)
    {
       Console.WriteLine(randMatrix[n,m]);
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}

/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

void task52()
{
    Console.WriteLine("*Задача 52. Вывод среднего арифметического в столбце");
    Console.Write("Введите число строк массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите число столбцов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    double[,] randMatrix = FillArray(n, m);
    Console.WriteLine("Полученный массив:");
    PrintMatrix(randMatrix);
    for (int j = 0; j < m; j++)
    {
        double sumColumn = 0;
        for (int i = 0; i < n; i++)
        {
            sumColumn = sumColumn + randMatrix[i, j];
        }
        Console.WriteLine($"Среднее арифметическое в столбце {j + 1}: {sumColumn / n}");
    }

}


//task47();
//task50();
task52();
