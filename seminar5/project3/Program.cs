/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] GeneratDoubleArray(int length)
{
    double[] array = new double[length];
    Random myRandom = new Random();
    
    for (int i = 0; i < length; i++) 
    {
        array[i] = Math.Round(myRandom.NextDouble() * 100,2);
    }
    return array;
}

void ShowArray (double[] array)
{  
    //Вывод с помощью foreach
    foreach (var elem in array) 
    {
        Console.Write("{0} ", elem);
    }

    Console.WriteLine();
}

double GetDiferenseMaximumAndMinimum(double[] array)
{
    double diferense = 0; 
    double max = array[0];
    double min = array[0];
   

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }

        if(array[i] > max)
        {
            max = array[i];
        } 
    }   
    
    diferense = Math.Round(max -min,2);

    return diferense;
}

Console.Write("Введите длиннц массива: ");
int length = int.Parse(Console.ReadLine());

double[] array = GeneratDoubleArray(length);
ShowArray(array);

double diferense = GetDiferenseMaximumAndMinimum (array);
Console.WriteLine(diferense); 