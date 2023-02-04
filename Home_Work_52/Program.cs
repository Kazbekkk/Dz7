/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

Random r = new Random();

int line, column; double arithmetic;

Console.Write("Введите количесвто строк в массиве: ");
line = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
column = int.Parse(Console.ReadLine());

int[,] array = Aritmet(line, column);

int [,] Aritmet(int lineAri, int columnAri)
{
    int[,] arr = new int[lineAri, columnAri];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = r.Next(-10, 10 + 1);
            Console.Write($"[{String.Join(", ", arr[i, j])}] ");
        }

        Console.WriteLine();
    }

    double[] arithmetic = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0) + 1; j++)
        {
            if (j < arr.GetLength(0))
            {
            arithmetic[i] += arr[j,i];
            }
            else
            {
                arithmetic[i] /= arr.GetLength(0);
                Console.WriteLine($"Среднее арифметическое элемента в столбце {i + 1} будет {arithmetic[i]:f2} ");
            }
        }
    }


    return arr;
    
}
