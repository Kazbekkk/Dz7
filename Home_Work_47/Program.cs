/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.Clear();

Random r = new Random();

int line, column; 

Console.Write("Введите количесвто строк в массиве: ");
line = int.Parse(Console.ReadLine());

Console.Write("Введите количесвто столбцов в массиве: ");
column = int.Parse(Console.ReadLine());
int [,] array = ArrayMet(line, column);

int[,] ArrayMet(int lineMet, int columnMet)
{
    int[,] arr = new int[lineMet, columnMet];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = r.Next(-10, 10 + 1);
            Console.Write($"{String.Join(" " , arr[i,j])}, ");
        }
        Console.WriteLine();
    }
    return arr;
}
