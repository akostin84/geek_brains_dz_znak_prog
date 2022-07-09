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
            randomArray[i, j] = Math.Round(rand.NextDouble() * 10 - 5, 1);
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
//task52();

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
void SelectionSort(double[] arrayToSort)
{
    int minPosition = 0;
    for (int i = 0; i < arrayToSort.Length - 1; i++)
    {
        minPosition = i;
        for (int j = i + 1; j < arrayToSort.Length; j++)
        {
            if (arrayToSort[j] < arrayToSort[minPosition]) minPosition = j;
        }
        double temp = arrayToSort[i];
        arrayToSort[i] = arrayToSort[minPosition];
        arrayToSort[minPosition] = temp;
        
    }
}

void SelectionSortRow(double[,] arrayToSort)
{
    int minPosition = 0;
    double temp = 0;
    for (int row = 0; row < arrayToSort.GetLength(0); row++)
    {
        minPosition = 0;
        for (int i = 0; i < arrayToSort.GetLength(1) - 1; i++)
        {
            minPosition = i;
            for (int j = i + 1; j < arrayToSort.GetLength(1); j++)
            {
                if (arrayToSort[row, j] < arrayToSort[row, minPosition]) minPosition = j;
            }
            temp = arrayToSort[row, i];
            arrayToSort[row, i] = arrayToSort[row, minPosition];
            arrayToSort[row, minPosition] = temp;
        }
    }
}

void Task54()
{
    Console.WriteLine("*Задача 54. Сортировка двумерного массива действительных чисел");
    Console.Write("Введите число строк массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите число столбцов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    double[,] randMatrix = FillArray(n, m);
    Console.WriteLine("Массив до сортировки:");
    PrintMatrix(randMatrix);
    Console.WriteLine("Массив после сортировки:");
    SelectionSortRow(randMatrix);
    PrintMatrix(randMatrix);
}

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

void Task56()
{
    Console.WriteLine("*Задача 56. Вывод номера строки с наименьшей суммой элементов");
    Console.Write("Введите число строк массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.Write("Введите число столбцов массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    double[,] randMatrix = FillArray(n, m);
    Console.WriteLine("Полученный массив:");
    PrintMatrix(randMatrix);
    int minRow = 0;
    double minSum = 0;
    for (int row = 0; row < n; row++)
    {
        double sumRow = 0;
        for (int column = 0; column < m; column++)
        {
            sumRow = sumRow + randMatrix[row, column];
        }
        if (minSum > sumRow)
        {
            minRow = row;
            minSum = sumRow;
    }
    }
    Console.WriteLine($"Строка {minRow} с минимальной суммой {minSum}");
}


//Task54();
Task56();