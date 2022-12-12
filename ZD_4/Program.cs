int a=0, b=0, c=0, Max=0;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);
if (a > Max ) Max=a;
if (b > Max ) Max=b;
if (c > Max) Max=c;
Console.Write($"Максимальное из трех чисел: {Max}");

