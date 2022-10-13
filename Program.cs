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



//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void GetDistance()
{
    Console.WriteLine("Введите координаты первой точки: ");
    int x1 = int.Parse(Console.ReadLine());
    int y1 = int.Parse(Console.ReadLine());
    int z1 = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координаты второй точки: ");
    int x2 = int.Parse(Console.ReadLine());
    int y2 = int.Parse(Console.ReadLine());
    int z2 = int.Parse(Console.ReadLine());
    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    
    Console.WriteLine(distance);
}    
GetDistance();

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
void GetCube()
{
    int N = int.Parse(Console.ReadLine());
    for (int i = 1; i <= N; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine(result);
    }
}
GetCube();


