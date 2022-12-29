// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] arr = new int [5, 5];

for (int i = 0; i < 5; i++) 
{
    for (int j = 0; j < 5; j++)
    {
        arr[i,j] = new Random().Next(0, 10);
        Console.Write(arr[i,j]);
    }
  Console.WriteLine();
}
double count;
for (int i = 0; i < 5; i++) 
{   
    count = 0;
    for (int j = 0; j < 5; j++)
    {
        count = count + arr[j, i];
    }
    Console.Write(count/5);
  Console.WriteLine();
}