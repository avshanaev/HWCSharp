/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 
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

int[,] multiplicationArray(int[,] arrayFirst, int[,] arraySecond)
{
    int rowLengthFirst = arrayFirst.GetLength(0);
    int colomnLengthFirst = arrayFirst.GetLength(1);

    int rowLengthSecond = arraySecond.GetLength(0);
    int colomnLengthSecond = arraySecond.GetLength(1);

    int[,] resultArray = new int[rowLengthFirst, colomnLengthSecond];


    for (int i = 0; i < rowLengthFirst; i++)
    {
        for (int j = 0; j < colomnLengthSecond; j++)
        {
            for (int k = 0; k < rowLengthSecond; k++)
            {
                resultArray[i, j] += arrayFirst[i, k] * arraySecond[k, j];
            }
        }
    }
    return resultArray;
}

Console.Write("Введите количество строк массива: ");
int rowLength = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colomnLength = int.Parse(Console.ReadLine());

int[,] arrayFirst = GeneratIntArray(rowLength, colomnLength);
ShowArrayAsTable(arrayFirst);

int[,] arraySecond = GeneratIntArray(colomnLength, rowLength);
ShowArrayAsTable(arraySecond);

int[,] resultArray = multiplicationArray(arrayFirst, arraySecond);
ShowArrayAsTable(resultArray);

