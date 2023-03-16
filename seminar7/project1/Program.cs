/* 
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


double[,] GeneratIntArray(int rowLength, int colomnLength)
{
    double[,] array = new double[rowLength, colomnLength];
    Random myRandom = new Random();

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colomnLength; j++)
        {
            array[i, j] = Math.Round((myRandom.NextDouble() * 100),3);
        }
    }

    return array;
}
//вывод строкой
void ShowArrayinLine (double[,] array)
{  
    foreach (var elem in array) 
    {
        Console.Write("{0} ", elem);
    }

    Console.WriteLine();
}

//вывод таблицей
void ShowArrayAsTable(double[,] array)
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

Console.Write("Введите количество строк массива: ");
int rowLength = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int colomnLength = int.Parse(Console.ReadLine());

double[,] array = GeneratIntArray(rowLength, colomnLength);
ShowArrayAsTable(array);
ShowArrayinLine(array);
