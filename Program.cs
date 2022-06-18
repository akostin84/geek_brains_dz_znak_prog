/* 
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да 
*/

string AskNumber()
{
    Console.WriteLine("Введите ваше число");
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

