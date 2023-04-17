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
}

int Bass(String msg)
{
    System.Console.WriteLine(msg);
    String.ReadInpute = System.Console.ReadLine();
    int result = int.Parse(ReadInpute);
    return result;
}

int [,] GetArray(int rows,int columns, int min, int max)
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