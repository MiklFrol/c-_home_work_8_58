// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] get2DArray(int colLenght, int rowLenght, int start, int finish)
{
    int[,] array = new int[colLenght, rowLenght];
    for (int i = 0; i < colLenght; i++)
    {
        for (int j = 0; j < rowLenght; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}

void printInColor(string data)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] array)
{
     Console.Write(" \t");
    for (int j = 0; j < array.GetLength(1); j++)
    {
         printInColor(j + "\t");
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor( i + "\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {       
            Console.Write(array[i, j] + "\t"); 
        }
        Console.WriteLine();
    }
}

int[,] getResultArray(int[,] array, int[,]array2)
{
    int[,] resultArray = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] += array[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}

int[,] array = get2DArray(3, 3, 1, 10);
int[,] array2 = get2DArray(3, 3, 1, 10);
print2DArray(array);
Console.WriteLine();
print2DArray(array2);
Console.WriteLine();
int[,] resultArray = getResultArray(array, array2);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Результирующая матрица будет:");
Console.ResetColor();
print2DArray(resultArray);