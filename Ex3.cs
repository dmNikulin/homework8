// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] array = new int[2, 2];
int[,] numbers = new int[2, 2];

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

array[0, 0] = 2;
array[0, 1] = 4;
array[1, 0] = 3;
array[1, 1] = 2;

numbers[0, 0] = 3;
numbers[0, 1] = 4;
numbers[1, 0] = 3;
numbers[1, 1] = 3;

PrintArray(array);

Console.WriteLine("__________________________________________");
Console.WriteLine();


PrintArray(numbers);

Console.WriteLine("__________________________________________");
Console.WriteLine();

int[,] ArrayEqual(int[,] a, int[,] b)
{

    int[,] result = new int[a.GetLength(0), b.GetLength(1)];

    if (a.GetLength(1) == b.GetLength(0))
    {
        
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(0); j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < b.GetLength(0); k++)
                {
                    result[i, j] = a[i, k] * b[k, j] + result[i, j];
                }
            }
        }
        return result;
    }

    else 
    {
        Console.WriteLine("Перемножить матрицы невозможно!");
        return a;
    };

}

int[,] mass = ArrayEqual(array, numbers);
PrintArray(mass);
