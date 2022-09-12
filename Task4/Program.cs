// Найти сумму по главной диагонали.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Clear();

Console.Write("количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);
Console.WriteLine();
FindSumDiagonal(array);

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

void FindSumDiagonal(int[,] array)
{
    int[] diagonalNumbers = new int[Math.Min(rows, columns)];
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        {
                sum+= array[i,i];
                diagonalNumbers[i] = array[i,i];
        }
        
    }
    Console.WriteLine($"Сумма элементов диагонали: ");
    Console.Write($"({String.Join(") + (", diagonalNumbers)})");
    Console.WriteLine($" = {sum}");
}