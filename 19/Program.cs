// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine());

if ((num > 10000) && (num < 100000))
{
    if ((num % 10) == (num / 10000) && ((num % 100) / 10) == ((num / 1000) % 10)) Console.WriteLine($"{num} палиндром");
    else Console.WriteLine($"{num} не палиндром");
}

else Console.WriteLine($"{num} не пятизначное");