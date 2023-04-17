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
    int rows = ("rows");
    int columns = ("columns");
    int num = ("number");

    int[,] matrix = GetArray(rows, columns, 5, 10);
    ChislNum2(num);
}


int ChislNum2(int num)
{
    if (i == num) return i;
    else if (i != num) i++;
    else return Console.WriteLine("not number");
}

int ChislNum(int num)
{
    for (int i = 0; i <= rows; i++)
    {
        for(int j = 0; j <= columns; j++)
        {
            array[i,j] == num;
        }
    }
    return array;
}

int Bass(String msg)
{
    System.Console.WriteLine(msg);
    String.ReadInpute = System.Console.ReadLine();
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


//void PrintMatrix(double[,] matrix)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         for (int n = 0; n  < matrix.GetLength(1); n++)
//         {
//             System.Console.Write($"{matrix[m, n]} ");

//         }
//         System.Console.WriteLine();
//     }
// }
