/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]

*/ 

void showArrayRangeNum (int num)
{
    int[] array = new int[num];
    Random myRandom = new Random();
    
    //Ввод с помощью for
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = myRandom.Next(0, num);
    }
   
    //Вывод с помощью foreach
    foreach (var elem in array) 
    {
        Console.Write("{0} ", elem);
    }
}
Console.Write("Введите пятизначное число:");
int num = int.Parse(Console.ReadLine());
showArrayRangeNum (num);