/* 
Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
- в контрольном примере ошибка:
подставим данные  в уравнение
-> -0,5 = 5 * - 0,5 + 2;
-> -0,5 = -2,5+2
 */

void printCrosPoint(int a1, int b1, int a2, int b2)
{
    double x = 0;
    double y = 0;

    x = Convert.ToDouble(b1- b2)/Convert.ToDouble(a2-a1);
    y = a2 * x + b2;

    Console.WriteLine("Координаты точки перечений функций");
    Console.WriteLine($"y = {a1}x + {b1}  и y = {a2}x + {b2}");
    Console.WriteLine($"x = {x}; y = {y}");   
}
Console.WriteLine("Укажите параметны для 2х уравнений типа : F(x) = ax + b ");

Console.Write("Введите первую константу для первой функции: ");
int a1 = int.Parse(Console.ReadLine());

Console.Write("Введите вторую константу для первой функции: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Введите первую константу для второй функции: ");
int a2 = int.Parse(Console.ReadLine());

Console.Write("Введите вторую константу для второй функции: ");
int b2 = int.Parse(Console.ReadLine());

printCrosPoint(a1, b1, a2, b2);