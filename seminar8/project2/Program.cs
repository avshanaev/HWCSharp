/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
*/

int[,] GeneratIntArray(int rowLength, int colomnLength)
{
    int[,] array = new int[rowLength, colomnLength];
    Random myRandom = new Random();

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colomnLength; j++)
        {
            array[i, j] = myRandom.Next(0, 10);
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

void ShowRowWithMinSum(int[,] array)
{
    int minimumRowSum = 0;
    int minI = 0;
    int rowLength = array.GetLength(0);
    int colomnLength = array.GetLength(1);

    for (int i = 0; i < rowLength; i++)
    {
        int tempIRowSum = 0;
        for (int j = 0; j < colomnLength; j++)
        {
            tempIRowSum += array[i, j];
        }

        if ((minimumRowSum > tempIRowSum) || (i == 0))
        {
            minimumRowSum = tempIRowSum;
            minI = i;
        }
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов:{minI}");
}

Console.Write("Введите количество строк массива: ");
int rowLength = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colomnLength = int.Parse(Console.ReadLine());

int[,] array = GeneratIntArray(rowLength, colomnLength);
ShowArrayAsTable(array);

ShowRowWithMinSum(array);

