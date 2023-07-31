// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void PrintArray(int[,] block) // Функция вывожа массива
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

FillArray(array);
PrintArray(array);

Console.WriteLine("__________________________________________");
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int count = 0; count < array.GetLength(1); count++)
        {
           if (array[i,j] > array[i,count])
           {
                int temp = array[i,j];
                array[i,j] = array[i,count];
                array[i,count] = temp;
           }
        }
    }
}

PrintArray(array);
