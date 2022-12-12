Console.Clear();

Console.Write("Введите число:   ");
string txt = Console.ReadLine();
int N = Convert.ToInt32(txt);
int num = 0;
Console.WriteLine($"Чётные числа из диапазона от 1 до {N}:");
while (num < N)
{
    num++;
    if (num % 2 == 0) 
    Console.Write($"{num} ");
}
Console.WriteLine(); 
Console.WriteLine();