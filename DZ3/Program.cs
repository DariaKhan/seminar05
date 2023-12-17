// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

// Пишем метод для нахождения строки с наименьшей суммой элементов.
// Создаем одномерный массив, в который вписываем в качестве элементов
//сумму по каждой строке.

int [] SearchTheSmallestSum (int[,] array) 
{
    int [] array1 = new int [array.GetLength(0)]; 
    for (int i = 0; i<array.GetLength(0); i++)
    {
        int SumInRow = 0;
        for (int j = 0; j< array.GetLength(1); j++)
        {
           SumInRow += array[i,j];
        }
        array1 [i] = SumInRow;
    }
return array1;
}

// Пишем метод для вывода на печать наименьшего значения одномерного массива.
// Это значение соответствует наименьшей сумме по строке двумерного массива.
// А индекс значения соответствует индексу строки.

void PrintTheSmallestElement (int[] array) 
{
   int min = array [0];
   int minIndex = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array [i] < min) 
      {
         min = array [i];
         minIndex = i;
      }
   }
   System.Console.WriteLine ($"Наименьшей суммой двумерного массива по строке является '{min}' в строке с индексом '{minIndex}'");
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

// Пишем метод для отображения созданного одномерного массива.
// Каждому элементу соответствует сумма элементом по строкам
// двумерного масиива.

void PrintArray(int [] array)
{
     System.Console.Write ("Новый массив из cумм значений по строкам двумерного массива: [ ");
    for (int i =0; i<array.Length; i++)
    {
        System.Console.Write (array[i] + " ");
    }
    System.Console.Write ("]");
}


int [,] MyArray = Create2DArray (5,7,0,10);
Print2DArray (MyArray);
System.Console.WriteLine ();
int [] MyArray1 = SearchTheSmallestSum(MyArray);
PrintArray (MyArray1);
System.Console.WriteLine ();
PrintTheSmallestElement(MyArray1);