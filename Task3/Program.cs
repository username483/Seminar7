// // Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
Console.Clear();

Console.Write("количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(FillArrayCheck(array));

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }

    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            Console.Write(filledArray[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int[,] FillArrayCheck(int[,] array)
{
    int[,] Newarray = array;
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                array[i, j] *= array[i, j];
            }
        }

    }
    return array;
}

