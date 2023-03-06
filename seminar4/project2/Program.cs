/*  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/


int getSumNumber(int a)
{
    int tempNum = a;
    int result = 0;
    while (tempNum != 0)
    {
        result += tempNum % 10;
        tempNum /= 10;
    }

    return result;
}

Console.Write("Введите пятизначное число:");
int a = int.Parse(Console.ReadLine());
int sum = getSumNumber(a);
Console.Write("Введите пятизначное число:");
Console.Write(sum);