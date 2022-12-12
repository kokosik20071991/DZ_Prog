int a, b;
int Max=0, Min=0;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
if (a > b)
{
    Max=a;
    Min=b;
    Console.Write($"Max={a}, Min={b}");
}
else
{
    Min=a; 
    Max=b;
    Console.Write($"Min={a}, Max={b}");
}
