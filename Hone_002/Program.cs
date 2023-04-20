// Задача 50. Напишите программу, которая на вход принимает элемент 
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
    int[,] matrix = new int[5,6];
    GetArray(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintNum(matrix);
    
}


void GetArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j  < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-5, 7);
        }
    
    }

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j  < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");

        }
        System.Console.WriteLine();
    }
}



void PrintNum(int[,] array)
{
    Console.WriteLine("Vvedute cheslo: ");
    int number = int.Parse(Console.ReadLine());
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number)
            {
                System.Console.Write($"Znachenie indexa {number} yavlyaetsyz pozeciz {i} e {j} ");
                index = 1;
                break;
            }
        }
    }
    if (index == 0)
    {
        System.Console.WriteLine("takogo chesla ne suschestvuet");
    }
    Console.WriteLine();
}


