﻿/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());

if (99 < a && a < 1000) Console.WriteLine((a % 100) / 10);
else Console.WriteLine("Введеное число не соответсвует требованиям.");