// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого 
// элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console. Write("Введите номер строки: ");
int stringNum = Convert.ToInt32(Console.ReadLine());
 Console. Write("Введите номер столбца: ");
int columnNum = Convert.ToInt32(Console.ReadLine()); 
int [,]arr = new int [5, 5];

for (int i = 0; i < 5; i++ )
{
    for(int j = 0; j < 5; j++)
    {
        arr[i,j] = new Random().Next(); 
    }
}
if (stringNum > 5 || columnNum > 5)
{
    Console.Write("Такого элемента нет");
}
else
{
  Console.Write(arr[stringNum,columnNum]);  
}
