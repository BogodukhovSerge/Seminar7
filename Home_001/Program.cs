// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Bass(string sms)
{
    System.Console.WriteLine(sms);
    String readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int[,] GetArray(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums.];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = rand.Next(min, max + 1);
        }
    }
    return array;

}



