using System;
using static System.Console;

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++){
        
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

WriteLine("Введите число n: ");
int n = int.Parse(ReadLine());
WriteLine("Введите число m: ");
int m = int.Parse(ReadLine());
int [,] array = GetArray(m, n);
PrintArray(array);