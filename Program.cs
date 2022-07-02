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

task41();
task43();
