/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
 */

int getCountPositivNums(int num)
{
    int result = 0;
    string temp = "";
    Console.WriteLine("Для досрочного прекращения ввода введите: c" );

    for (int i = 0; i < num; i++)
    {
        temp = Console.ReadLine();

        if (temp == "c")
        {
            break;
        } 

        if (int.Parse(temp)>0)
        {
            result++;
        }
    } 

    return result;
}
Console.Write("Введите колличество чисел для ввода: ");
int num = int.Parse(Console.ReadLine());

int countNegativNums = getCountPositivNums(num);
Console.WriteLine(countNegativNums);