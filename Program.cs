/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

/*
Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
*/
void FillRow(double[,] arrayToFill, int row, int startIndex, int lastIndex)
{
    Random rand = new Random();
    for (int column = startIndex; column <= lastIndex; column++)
    {
        arrayToFill[row, column] = Math.Round(rand.NextDouble() * 15 + 1, 1);
    }
}

void FillColumn(double[,] arrayToFill, int column, int startIndex, int lastIndex)
{
    Random rand = new Random();
    for (int row = startIndex; row <= lastIndex; row++)
    {
        arrayToFill[row, column] = Math.Round(rand.NextDouble() * 15 + 1, 1);
    }
}

void Task58()
{
    Console.WriteLine("*Задача 58. Заполнить массив спирально");
    int n = 4;
    int m = 4;
    double[,] randMatrix = new double[n, m];
    Console.WriteLine("Полученный массив:");
    int rowMoves = n;
    int columnMoves = m - 1;
    int totalMoves = rowMoves + columnMoves;
    int moveRow = 0;
    int moveColumn = 0;
    for (int move = 1; move <= totalMoves; move++)
    {
        if (move % 2 != 0)
        { // row move
            moveRow++;
            if (moveRow % 2 != 0) FillRow(randMatrix, (moveRow - 1) / 2, (moveRow - 1) / 2, n - (moveRow - 1) / 2 - 1);
            if (moveRow % 2 == 0) FillRow(randMatrix, n - moveRow / 2, (moveRow - 1) / 2, n - moveRow / 2 - 1);
        }
        else
        { // column move
            moveColumn++;
            if (moveColumn % 2 != 0) FillColumn(randMatrix, (m - (moveColumn - 1) / 2 ) - 1, (moveColumn + 1) / 2, m - moveColumn / 2 - 1);
            if (moveColumn % 2 == 0) FillColumn(randMatrix, moveColumn / 2 - 1, (moveColumn + 1) / 2, m - moveColumn / 2 - 1);     
        }
    PrintMatrix(randMatrix);
    }
}

Task54();
Task56();
Task58();