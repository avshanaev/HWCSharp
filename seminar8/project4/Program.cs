/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] GeneratIntArray(int xLength, int yLength, int zLength)
{
    int[,,] array = new int[xLength, yLength, zLength];
    int num = 10;

    for (int i = 0; i < xLength; i++)
    {
        for (int j = 0; j < yLength; j++)
        {
            for (int k = 0; k < zLength; k++)
            {
                array[i, j, k] = num;
                num++;
            }

        }
    }

    return array;
}

//вывод таблицей
void ShowArray(int[,,] array)
{
    int xLength = array.GetLength(0);
    int yLength = array.GetLength(1);
    int zLength = array.GetLength(2);

    for (int i = 0; i < xLength; i++)
    {
        for (int j = 0; j < yLength; j++)
        {
            for (int k = 0; k < zLength; k++)
            {
                Console.Write($"{array[i, j, k]}:({i}:{j}:{k}); " );
            }
            Console.WriteLine();
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

Console.Write("Введите размер равностороннего массива: ");
int Length = int.Parse(Console.ReadLine());

int[,,] array = GeneratIntArray(Length, Length, Length);
ShowArray(array);



