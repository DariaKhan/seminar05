// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

// Задание выполнила Дарья Хан, 15/12/2023

// Пишем метод для создания двумерного массива:
int[,] Create2DArray(int rows, int columns, int min, int max)
{
   int[,] array = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < columns; j++)
      {
         array[i, j] = new Random().Next(min, max);
      }
   }
   return array;
}

// Пишем метод для смены местами первой и последней строки массива:

int[,] InterchangedRows(int[,] array)
{
   for (int j = 0; j < array.GetLength(1); j++)
      {
         int temp = array[0, j];
         array[0, j] = array[array.GetLength(0)-1, j];
         array[array.GetLength(0)-1, j] = temp;
      }
   return array;
}
// Пишем метод для отображения созданного двумерного массива.
void Print2DArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         System.Console.Write(array[i, j] + " ");
      }
      System.Console.WriteLine();
   }
}


int[,] MyArray = Create2DArray(4, 8, 0, 10);
Print2DArray(MyArray);
System.Console.WriteLine();
Print2DArray(InterchangedRows(MyArray));