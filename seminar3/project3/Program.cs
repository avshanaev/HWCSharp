﻿/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125
*/

void ShowCube(int num)
{
    for (int i = 0; i <= num; i++)
{
    double cube = Math.Pow(i,3);
    Console.Write($"{cube}, ");    
}
}

Console.Write("Введите число: ");
int num =  int.Parse(Console.ReadLine());
ShowCube(num);


