/* 
Задача со звездочкой Найти второй максимум в массиве.
4, 4, 3, 0, 2 => 3
 */

int[] GeneratIntArray(int length, int startRange = -9, int endRange = 10)
{
    int[] array = new int[length];
    Random myRandom = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(startRange, endRange);
    }
    return array;
}

void ShowArray(int[] array)
{
    //Вывод с помощью foreach
    foreach (var elem in array)
    {
        Console.Write("{0} ", elem);
    }

    Console.WriteLine();
}

void ShowSecondMaximum(int[] array)
{
    int firstMaximum = array[0];
    int secondMaximum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (firstMaximum < array[i])
            firstMaximum = array[i];

        if (firstMaximum == secondMaximum && secondMaximum > array[i])
            secondMaximum = array[i];

        if (secondMaximum < array[i] && firstMaximum > array[i])
            secondMaximum = array[i];
    }
    System.Console.WriteLine(secondMaximum);
}

// Console.Write("Введите длинну массива: ");
// int length = int.Parse(Console.ReadLine());

// Console.Write("Введите начало интервала: ");
// int start = int.Parse(Console.ReadLine());

// Console.Write("Введите окнчание интервала: ");
// int finish = int.Parse(Console.ReadLine());

// int[] array = GeneratIntArray(length, start, finish);

int[] array = {3,4,4,0,2};

ShowArray(array);

ShowSecondMaximum(array);//по умолчанию возвращает количество по четным, при установке второго параметра в ложь возвращает по нечетные
