/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] GeneratIntArray(int length, int startRange = - 9, int endRange = 10)
{
    int[] array = new int[length];
    Random myRandom = new Random();
    
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = myRandom.Next(startRange,endRange);
    }
    return array;
}

void ShowArray (int[] array)
{  
    //Вывод с помощью foreach
    foreach (var elem in array) 
    {
        Console.Write("{0} ", elem);
    }

    Console.WriteLine();
}

int GetCountEvenNumbers(int[] array, bool isEven = true)
{
    int count = 0; 

    for (int i = 0; i < array.Length; i++) 
    {
        if (isEven != Convert.ToBoolean(array[i]%2) )
        {
           count++;
        }
    }   
    return count;
}

Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

Console.Write("Введите начало интервала: ");
int start =  int.Parse(Console.ReadLine());

Console.Write("Введите окнчание интервала: ");
int finish = int.Parse(Console.ReadLine());

int[] array = GeneratIntArray(length, start, finish);
ShowArray(array);

int countNumbers = GetCountEvenNumbers(array);//по умолчанию возвращает количество по четным, при установке второго параметра в ложь возвращает по нечетные
Console.WriteLine(countNumbers); 