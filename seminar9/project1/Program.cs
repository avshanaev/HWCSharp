/* 
Задача 1: Задайте значение N. Напишите программу, 
которая выведет все четные натуральные числа в промежутке от m до N .
Выполнить с помощью рекурсии.

M, N = 5, 8 -> "6, 8"
M, N = 2, 4 -> "2, 4"
 */

// операторные скобочки у if не ставлю специально, так как в данном случае проще читается.

void showEvenNumbers(int m,int n)
{
    if (n < m)    
       return; 
    
    if (n % 2 ==1)
        n--;     

    System.Console.WriteLine(n);
    showEvenNumbers( m, n-2);
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (m>n)
    (m,n)=(n,m);

showEvenNumbers(m,n);