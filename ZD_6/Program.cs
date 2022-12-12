int a;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
if (a %2==0)
{
    Console.Write("Четное число");
}
else
{
    Console.Write("Нечентное число");
}