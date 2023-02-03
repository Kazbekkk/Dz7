/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
Console.Clear();

Random r = new Random();

int line, column, search, counter, numSearch, check, lineSearch, columnSearch;

Console.Write("Введите количесвто строк в массиве: ");
line = int.Parse(Console.ReadLine());

Console.Write("Введите количесвто столбцов в массиве: ");
column = int.Parse(Console.ReadLine());

Console.Write("Введите число которое хотите найти в массиве: ");
search = int.Parse(Console.ReadLine()); // номер позиции элемента в массиве  

int[,] array = ArrayMet(line, column);


int[,] ArrayMet(int lineMet, int columnMet)
{
    
    numSearch = 0; // число найденое
    lineSearch = 0; // строка найденого числа 
    columnSearch = 0; // столбец найденого числа 
    check = 0; // Проверка. Если рано нулю значит число не нашли
    int[,] arr = new int[lineMet, columnMet];
    counter = 0; // счетчик 

    for (int i = 0; i < arr.GetLength(0); i++) // строки двумерного массива
    {
        for (int j = 0; j < arr.GetLength(1); j++) // столбцы двумерного массива
        {
            arr[i, j] = r.Next(-10, 10 + 1);
            if (counter == search) // если счетчик == номеру позиции элемента присваеваем значение numSearch
            {
                numSearch = arr[i, j];
                lineSearch = i;
                columnSearch = j;
                check ++; // Если рано единице значит число  нашли
            }
            counter++;
            Console.Write($"{String.Join(" ", arr[i, j])}, ");

        }
        Console.WriteLine();

    }
    if (check > 0) Console.WriteLine($"Число под индексом {search} будет {numSearch} и находится в {lineSearch} строке; {columnSearch} столбце ");
    else Console.WriteLine($"Число под индексом {search} нету");

    return arr;
}