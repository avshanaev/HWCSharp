// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Вводим первое число
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine());

// Вводим второе число
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());

// Вводим третье число
Console.Write("Введите третье число:");
int c = int.Parse(Console.ReadLine());

if ((a > b) & (a > c)) Console.WriteLine($"Максимум = {a}");
else if ((b > a) & (b > c)) Console.WriteLine($"Максимум = {b} ");
     else Console.WriteLine($"Максимум = {c}");
