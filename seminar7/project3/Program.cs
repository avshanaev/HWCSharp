/*  
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GeneratIntArray(int rowLength, int colomnLength, int startRange = 0, int endRange = 20)
{
    int[,] array = new int[rowLength, colomnLength];
    Random myRandom = new Random();

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colomnLength; j++)
        {
            array[i, j] = myRandom.Next(startRange, endRange);
        }
    }

    return array;
}

//вывод таблицей
void ShowArrayAsTable(int[,] array)
{
    int rowLength = array.GetLength(0);
    int colomnLength = array.GetLength(1);
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colomnLength; j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

void ShowAverageColomnFromArray(int[,] array)
{
    int rowLength = array.GetLength(0);
    int colomnLength = array.GetLength(1);
    Console.Write("Среднее арифметическое каждого столбца:");
    for (int i = 0; i < colomnLength; i++)
    {
        int sum = 0;
        for (int j = 0; j < rowLength; j++)
        {
            sum += array[j, i];
        }
        Console.Write($"{Math.Round(((double)sum / rowLength),2)}; ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк массива: ");
int rowLength = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colomnLength = int.Parse(Console.ReadLine());

int[,] array = GeneratIntArray(rowLength, colomnLength);
ShowArrayAsTable(array);

Console.WriteLine();
ShowAverageColomnFromArray(array);

