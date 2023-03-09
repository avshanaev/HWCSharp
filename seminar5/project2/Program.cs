/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

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

int GetSumEvenPosition(int[] array, bool isEven = true)
{
    int sum = 0; 
    int i = 0;

    if(isEven == false)
    {
        i = 1;
    }

    while(i < array.Length) 
    {
      sum += array[i];
      i+=2;  
    }   
    return sum;
}

Console.Write("Введите длиннц массива: ");
int length = int.Parse(Console.ReadLine());

Console.Write("Введите начало интервала: ");
int start =  int.Parse(Console.ReadLine());

Console.Write("Введите окнчание интервала: ");
int finish = int.Parse(Console.ReadLine());

int[] array = GeneratIntArray(length, start, finish);
ShowArray(array);

int sumEvenPosition = GetSumEvenPosition(array);//по умолчанию возвращает количество по четным, при установке второго параметра в ложь возвращает по нечетные
Console.WriteLine(sumEvenPosition);