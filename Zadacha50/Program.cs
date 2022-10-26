// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.Clear();
Console.Write("Введите количество строк (m) массива: "); int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n) массива: "); int n = int.Parse(Console.ReadLine());
Console.Write("Введите индекс по строке: "); int m1 = int.Parse(Console.ReadLine());
Console.Write("Введите индекс по столбцу: "); int n1 = int.Parse(Console.ReadLine());
int [,] array = new int [m, n];

void FillRandomTwoDimArray (int [,] array) // метод задает заполнения двумерного массива целыми числами
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {array[i, j] = new Random().Next(0, 100);}}}
void PrintTwoDimArray (int [,] array) // метод печатает двумерный массив
{for (int i = 0; i < m; i++)
{
   for (int j = 0; j < n; j++) {Console.Write(array[i, j] + "\t");}
   Console.WriteLine();
}}
void FindElementByIndex(int [,] array)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == m1 & j == n1)
        {
            // Console.WriteLine(array[m1, n1]);
            Console.WriteLine($"По индексам [{m1},{n1}] найдено число {array[m1, n1]}");
        }
    }
}
if (m < m1+1 | n < n1+1)
{Console.WriteLine($"[{m1},{n1}] -> такого числа в массиве нет");}
}
FillRandomTwoDimArray(array);
Console.WriteLine($"Сгенерирован массив на {m} строк(и) и {n} слобца(ов):");
PrintTwoDimArray(array);
FindElementByIndex(array);