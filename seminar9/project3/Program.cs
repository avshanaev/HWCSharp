/* 
Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

int ack(int n, int m)
{
  
  while (n != 0)
  {
    if (m==0)
        m = 1;
   
    else
        m =  ack(n,m-1);
   
    n = n-1;
  }
  return m + 1;
  
}

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine(ack(m, n));