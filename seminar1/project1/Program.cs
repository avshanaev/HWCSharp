// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Вводим первое число
Console.Write("Введите первое число:");
int a = int.Parse(Console.ReadLine());

// Вводим второе число
Console.Write("Введите второе число:");
int b = int.Parse(Console.ReadLine());

if (a > b) Console.WriteLine($"Первое число: {a} больще второго: {b}");
else if (a < b) Console.WriteLine($"Второе число: {b} больще первого: {a}");
     else Console.WriteLine($"числа: {a} и: {b} одинаковые");