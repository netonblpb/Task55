// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();
Random rnd = new Random();
Console.Write("Задайте размер по Х: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте размер по Y: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}

int count;
double sum;
for (int j = 0; j < n; j++)
{
    count = 0;
    sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + array[i, j];
        count++;
    } 
    Console.Write($"{sum / count}\t");
}
