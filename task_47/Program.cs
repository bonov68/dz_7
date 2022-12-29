// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// // m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,]arr = new double [5, 5];

for (int i = 0; i < 5; i++ )
{
    for(int j = 0; j < 5; j++)
    {
        arr[i,j] = Math.Round(new Random().NextDouble(), 3); 

        Console.Write($"{arr[i,j]}, ");
    }
Console.WriteLine();
}


