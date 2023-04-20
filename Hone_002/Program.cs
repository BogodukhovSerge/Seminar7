﻿// Задача 50. Напишите программу, которая на вход принимает элемент 
// в двумерном массиве, и возвращает его индексы первого найденого 
// числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



Nach();

void Nach()
{
    int rows = Bass("rows");
    int columns = Bass("columns");
    int num = Bass("number");

    int[,] matrix = GetArray(rows, columns, 5, 10);
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintChislo(matrix);

}


int Bass(String msg)
{
    System.Console.WriteLine(msg);
    String ReadInpute = System.Console.ReadLine();
    int result = int.Parse(ReadInpute);
    return result;
}

int[,] GetArray(int rows,int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    var random = new Random();
    for (int i = 0; i <= rows; i++)
    {
        for(int j = 0; j <= columns; j++)
        {
            array[i,j] = random.Next(min, max + 1);

        }
    }
    return array;

}


void PrintChislo(int[,] matrix)
 {
    int num = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n  < matrix.GetLength(1); n++)
        {
            if(num == matrix[m,n])
            {
                System.Console.Write($"Znachenie indexa {num} yzvlyaetsyz pozeciz {m} e {n} ");
                break;
            }

        }
        
    }
    if (num == 0)
    {
        System.Console.WriteLine("takogo chesla ne suschestvuet");
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n  < matrix.GetLength(1); n++)
        {
            System.Console.Write($"{matrix[m, n]} ");

        }
        System.Console.WriteLine();
    }
}

// int ChislNum2(int num)
// {
//     int array = 0;
//     int i = 0;  
//     int j = 0; 
//     if (array[i,j] == num) return i;
//     else if (i != num) i++;
//     return System.Console.WriteLine("not number");
// }

// int ChislNum(int num)
// {
//     int array = 0;
//     for (int i = 0; i <= rows; i++)
//     {
//         for(int j = 0; j <= columns; j++)
//         {
//             array[i,j] == num;
//         }
//     }
//     return array;
