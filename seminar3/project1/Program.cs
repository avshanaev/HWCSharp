/*
Задача 19: Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да

*/
void IsItPolindrom(int a)
{
if (a > 99999 && a < 10000)
{
    Console.WriteLine("Введенное число не соответствует требованиям - 5 цифр");
    return;
}
if (( a / 10000 == a % 10)
&& (( a / 1000 ) % 10 == (a % 100)/10))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
}

Console.Write("Введите пятизначное число:");
int a = int.Parse(Console.ReadLine());
IsItPolindrom(a);