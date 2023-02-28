/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите номер дня недели:");
int a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: 
        Console.WriteLine("Понедельник");
        break;
    
    case 2: 
        Console.WriteLine("Вторник");
        break;
    
    case 3: 
        Console.WriteLine("Среда");
        break;
    
    case 4: 
        Console.WriteLine("Четверг");
        break;
    
    case 5: 
        Console.WriteLine("Пятница");
        break;
   
    case 6:
        Console.WriteLine("Суббота");
        break;
   
    case 7: 
        Console.WriteLine("Воскресенье");
        break;
    
    default:
        Console.WriteLine("Дня недели с укзанным номером не существует.");
        break;
}