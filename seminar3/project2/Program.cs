/*
Задача 21: Напишите программу, которая принимает 
на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double GetLegthLine(int x1, int y1, int z1, int x2, int y2, int z2)
{

double xqd = Math.Pow(x2-x1,2);
double yqd = Math.Pow(y2-y1,2);
double zqd = Math.Pow(z2-z1,2);

double sqr = Math.Sqrt(xqd + yqd + zqd);

double resault = Math.Round(sqr,2);

return resault;

}

Console.Write("x1 = ");
int x1 =  int.Parse(Console.ReadLine());

Console.Write("y1 = ");
int y1 =  int.Parse(Console.ReadLine());

Console.Write("z1 = ");
int z1 =  int.Parse(Console.ReadLine());

Console.Write("x2 = ");
int x2 =  int.Parse(Console.ReadLine());

Console.Write("y2 = ");
int y2 =  int.Parse(Console.ReadLine());

Console.Write("z2 = ");
int z2 =  int.Parse(Console.ReadLine());

double LegthLine = GetLegthLine(x1, y1, z1, x2, y2, z2); 
Console.WriteLine($"Растояние между точками = {LegthLine}");
