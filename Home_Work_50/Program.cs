/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
Console.Clear();

Random r = new Random();

int line, column, search, counter, num1;

Console.Write("Введите количесвто строк в массиве: ");
line = int.Parse(Console.ReadLine());

Console.Write("Введите количесвто столбцов в массиве: ");
column = int.Parse(Console.ReadLine());

Console.Write("Введите число которое хотите найти в массиве: ");
search = int.Parse(Console.ReadLine());

int[,] array = ArrayMet(line, column);


int[,] ArrayMet(int lineMet, int columnMet)
{
    int[] arr1 = new int[1];
    int[,] arr = new int[lineMet, columnMet];
    counter = 0;
    for (int a = 0; a < arr1.GetLength(0); a++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = r.Next(-10, 10 + 1);
                if (counter == search)
                {
                    arr1[0] = arr[i, j];
                }
                counter++;
                Console.Write($"{String.Join(" ", arr[i, j])}, ");

            }
            Console.WriteLine();

        }
        if (arr1[0] > -1) Console.WriteLine($"Число под индексом {search} будет {arr1[0]}");
        else Console.WriteLine($"Число под индексом {search} нету");
    }

    return arr;
}