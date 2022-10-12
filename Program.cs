//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");

int GetFirstSymbols(int num, int NumberOfFirstSymbols)
{
    while (num / Math.Pow(10, NumberOfFirstSymbols) > 1)
    {
        num/=10;
    }
    return num;
}

int number = int.Parse(Console.ReadLine());
if (number < 0) number *= -1; 
if (number > 9999 && number < 100000)
{
    int x = GetFirstSymbols(number,2); 
    int y = number % 100;
    if (x/10 == y%10 && y/10 == x%10)
    {
        Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом");
    }
} 
else
{
    Console.WriteLine("Введенное число не является пятизначным");
}


