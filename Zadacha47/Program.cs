// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.Write("Введите количество столбцов (m) массива: "); int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк (n) массива n: "); int n = int.Parse(Console.ReadLine());
double [,] array = new double [m, n];

void FillRandomDoubleTwoDimArray (double [,] array) // метод задает заполнения двумерного массива вещественными числами
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {array[i, j] = new Random().NextDouble() * 10;}}}

void PrintTwoDimArray (double [,] array) // метод печатает двумерный массив
{for (int i = 0; i < m; i++)
{
   for (int j = 0; j < n; j++) {Console.Write("{0,2:F2}", array[i, j]); Console.Write("\t");}
   Console.WriteLine();
}}

FillRandomDoubleTwoDimArray(array);
PrintTwoDimArray(array);