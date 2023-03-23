/*
 Задача 2: Задайте значения M и N. 
 Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

int SumRange(int m,int n)
{
    if (n <= m)    
       return m;    

    return SumRange(m,n-1) + n;
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (m>n)
    (m,n)=(n,m);

System.Console.WriteLine(SumRange(m,n));