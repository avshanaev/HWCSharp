/* 
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет 
*/



int[,] GeneratIntArray(int rowLength, int colomnLength)
{
    int[,] array = new int[rowLength, colomnLength];
    Random myRandom = new Random();

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colomnLength; j++)
        {
            array[i, j] = myRandom.Next();
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

void ShowTargetPositionFromArray(int target, int[,] array)
{
    int rowLength = array.GetLength(0);
    int colomnLength = array.GetLength(1);

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colomnLength; j++)
        {
            if(target == array[i, j])
            {
                Console.WriteLine($"[{i},{j}]");
                return;
            }
        }
    }
   Console.WriteLine("такого числа в массиве нет"); 
}

Console.Write("Введите количество строк массива: ");
int rowLength = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colomnLength = int.Parse(Console.ReadLine());

int[,] array = GeneratIntArray(rowLength, colomnLength);
ShowArrayAsTable(array);

Console.Write("Введите число для поиска: ");
int target = int.Parse(Console.ReadLine());

ShowTargetPositionFromArray(target, array);
