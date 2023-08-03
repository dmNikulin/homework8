// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

void PrintArray(int[,,] block) // Функция вывода массива
{
    for (int j = 0; j < block.GetLength(0); j++)
    {
        for (int m = 0; m < block.GetLength(1); m++)
        {
            for (int t = 0; t < block.GetLength(2); t++)
            {
                Console.Write($"{block[j, m, t]} ");
            }
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] table)  // Функция заполнения массива
{
    for (int k = 0; k < table.GetLength(0); k++)
    {
        for (int l = 0; l < table.GetLength(1); l++)
        {
            for (int n = 0; n < table.GetLength(2); n++)
            {
                table[k, l, n] = new Random().Next(10, 100);
            }
        }
    }
}

int[,,] array = new int[2, 2, 2];

FillArray(array);
PrintArray(array);

Console.WriteLine("_________________________________________");
Console.WriteLine();

for (int k = 0; k < array.GetLength(0); k++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i, j, k]} ({i}, {j}, {k}); ");
        }
        Console.WriteLine();
    }
}
