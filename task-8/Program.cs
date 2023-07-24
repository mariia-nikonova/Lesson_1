Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine()!);

for(int i=1;i<=N;)
{
if (i % 2 == 0) System.Console.Write($"{i} ");
i=i+1;
}
