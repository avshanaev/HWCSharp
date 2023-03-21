/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] GetSpire(int n)
{
    int[,] result = new int[n, n];
    int maxRow = n - 1;
    int maxCol = n - 1;
    int minRow = 0;
    int minCol = 0;
    int currentChar = 10;

    //вывод индекса сделан для наглядности выполнения кода
    for (int k = 0; k < (n + 1) / 2; k++)
    {
        System.Console.WriteLine("Заполняем строку слева направо:");
        for (int i = minCol; i <= maxCol; i++)
        {
            System.Console.WriteLine($"i={i}");
            result[minRow, i] = currentChar;
            currentChar++;
        }
        minRow++;
        System.Console.WriteLine("Заполняем колонку сверху вниз:");
        for (int j = minRow; j <= maxRow; j++)
        {
            System.Console.WriteLine($"j={j}");
            result[j, maxCol] = currentChar;
            currentChar++;
        }
        maxCol--;
        System.Console.WriteLine("Заполняем строку справа налево:");
        for (int i = maxCol; i >= minCol; i--)
        {
            System.Console.WriteLine($"i={i}");
            result[maxRow, i] = currentChar;
            currentChar++;
        }
        maxRow--;
        System.Console.WriteLine("Заполняем колонку снизу вверх:");
        for (int j = maxRow; j >= minRow; j--)
        {
            System.Console.WriteLine($"j={j}");
            result[j, minCol] = currentChar;
            currentChar++;
        }
        minCol++;

    }
    return result;
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

Console.Write("Введите размер равностороннего массива: ");
int Length = int.Parse(Console.ReadLine());

int[,] array = GetSpire(Length);

ShowArrayAsTable(array);

