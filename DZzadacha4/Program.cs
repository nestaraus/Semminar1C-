Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    if (a>c)
    {
        Console.WriteLine("max = " + a);
    }

} 
else if (b>a)
{
    if (b>c)
    {
        Console.WriteLine("max = " + b);
    }

} 
if (c>a)
{
    if (c>b)
    {
        Console.WriteLine("max = " + c);
    }

} 


