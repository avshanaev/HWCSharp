/* 
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

int[,] GeneratIntArray(int rowLength, int colomnLength)
{
    int[,] array = new int[rowLength, colomnLength];
    Random myRandom = new Random();

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colomnLength; j++)
        {
            array[i, j] = myRandom.Next(0,10);
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

//метод для обмена элементов массива
static void Swap(ref int x, ref int y)
{
    var t = x;
    x = y;
    y = t;
}

//метод возвращающий индекс опорного элемента
static int Partition(int[,] array, int minIndex, int maxIndex, int rowindex)
{
    var pivot = minIndex - 1;
    for (var i = minIndex; i < maxIndex; i++)
    {
        if (array[rowindex, i] > array[rowindex, maxIndex])
        {
            pivot++;
            Swap(ref array[rowindex, pivot], ref array[rowindex, i]);
        }
    }

    pivot++;
    Swap(ref array[rowindex, pivot], ref array[rowindex, maxIndex]);
    return pivot;
}

//быстрая сортировка
void QuickSort(int[,] array, int minIndex, int maxIndex, int rowindex)
{
    if (minIndex >= maxIndex)
    {
        return;
    }

    var pivotIndex = Partition(array, minIndex, maxIndex, rowindex);
    QuickSort(array, minIndex, pivotIndex - 1, rowindex);
    QuickSort(array, pivotIndex + 1, maxIndex, rowindex);

    return ;
}


void SortItemInRowArray(int[,] array)
{
    int rowLength = array.GetLength(0);
    int colomnLength = array.GetLength(1);

    for (int i = 0; i < rowLength; i++)
    {
       QuickSort(array, 0, array.GetLength(1) - 1, i);
    }
    Console.WriteLine("такого числа в массиве нет");
}

Console.Write("Введите количество строк массива: ");
int rowLength = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colomnLength = int.Parse(Console.ReadLine());

int[,] array = GeneratIntArray(rowLength, colomnLength);
ShowArrayAsTable(array);

SortItemInRowArray(array);
ShowArrayAsTable(array);




