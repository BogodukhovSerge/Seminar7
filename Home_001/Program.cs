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

int[] GetArray(int Lenght, int minValui, int maxValui)
{
    int[] array = new int[Lenght];
    Random rand = new Random();
    for (int i = 0; i < Lenght; i++)
    {
        for (int j = 0; j < Lenght; j++)
        {
            array[j] = rand.Next(minValui, maxValui + 1);
        }
        array[i] = rand.Next(minValui, maxValui + 1);
    }
    return array;

}

