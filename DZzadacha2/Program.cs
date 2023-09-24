Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("max = " + a);
    Console.Write("min = " + b);
}
else
{
    Console.WriteLine("max = " + b);
    Console.Write("min = " + a);
}