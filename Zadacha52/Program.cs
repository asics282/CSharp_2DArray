// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.Write("Введите количество строк (m) массива: "); int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов (n) массива: "); int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

// следующие 4 строки отвечают за конверсию массива из int в double
double[] averegeColumn = new double[n]; // среднерифм. для столбца
double[] newAverege = new double[n];
double M;
M = (int)m;

void FillRandomTwoDimArray (int [,] array) // метод задает заполнения двумерного массива вещественными числами
{for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {array[i, j] = new Random().Next(0, 10);}}}

void PrintTwoDimArray (int [,] array) // метод печатает двумерный массив
{Console.WriteLine($"Сгенерирован массив на {m} строк(и) и {n} слобца(ов):");
for (int i = 0; i < m; i++)
{for (int j = 0; j < n; j++) {Console.Write(array[i, j] + " ");} Console.WriteLine();}}

FillRandomTwoDimArray(array);

PrintTwoDimArray(array);

void AveregeColumn (int [,] array, double M, double[] averegeColumn) // метод считает среднеарифметическое для каждого столбца двумерного массива
{
for (int j = 0; j < n; j++)
{double averege = 0; int sum = 0; for (int i = 0; i < m; i++)
    {sum += array[i, j];} //сумма элементов в столбце
    averege = sum/M; // среднеарифметическое
    averegeColumn[j] = averege;} // среднерифм. для j столбца
}

AveregeColumn (array,  M, averegeColumn);

void FromIntArrayToDoubleArray(double[] newAverege, double[] averegeColumn) // метод конвертирует массив целых чисел в вещественные
{
    for (int j = 0; j < n; j++)
    {newAverege[j] = (double)averegeColumn[j];}
}

FromIntArrayToDoubleArray(newAverege, averegeColumn);

void PrintAveregeColumnDouble(double[] newAverege, int n) // метод печатает попорядку значения среднеарифметического для каждого столбца двумерного массива
{Console.WriteLine(); Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < n; j++)
{if (j < n - 1) {Console.Write(newAverege[j] + "; ");} else {Console.Write(newAverege[j] + ".");} // вывод среднего арифм каждого столбца
}}

PrintAveregeColumnDouble(newAverege, n);