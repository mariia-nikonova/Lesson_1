Console.Write("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine()!);

if (numb1 > numb2) Console.WriteLine($"Max = {numb1}");
else Console.WriteLine($"Max = {numb2}");