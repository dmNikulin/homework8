// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] array = new int[4, 5];

void FillArray(int[,] table)  // Функция заполнения массива
{
    for (int k = 0; k < table.GetLength(0); k++)
    {
        for (int l = 0; l < table.GetLength(1); l++)
        {
            table[k, l] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] block) // Функция вывода массива
{
    for (int j = 0; j < block.GetLength(0); j++)
    {
        for (int m = 0; m < block.GetLength(1); m++)
        {
            Console.Write($"{block[j, m]} ");
        }
        Console.WriteLine();
    }
}
void PrintLineArray(int[] a) // Функция вывода одномерного массива
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

FillArray(array);
PrintArray(array);

Console.WriteLine("__________________________________________");
Console.WriteLine();

int[] SumOfArrayLine(int[,] a)
{
    int[] summary = new int[a.GetLength(0)];

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            summary[i] = a[i, j] + summary[i];
        }
    }
    return summary;
}


int[] sum = SumOfArrayLine(array);
int minSum = sum[0];
int lineMin = 0;

PrintLineArray(sum);

for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] < minSum)
    {
        minSum = sum[i];
    }
    for (int k = 0; k < sum.Length; k++)
    {
        if (minSum == sum[k])
        {
            lineMin = k+1; // +1 для удобства
        }
    }
}

Console.WriteLine($"Строка с наименьшей суммой: {lineMin}.");
Console.WriteLine($"Cумма равна: {minSum}");
