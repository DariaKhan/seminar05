// Задача 1: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Задание выполнила Дарья Хан, 15/12/2023

// Пишем метод для создания двумерного массива:
int[,] Create2DArray (int rows, int columns, int min, int max) 
{
    Random rand = new Random();
    int [,]array = new int [rows,columns];

    for (int i =0; i<rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
            array [i,j] = rand.Next(min,max);
        }
    }
return array;
}

// Метод для запроса у пользователя позиций элемента:

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// Пишем метод для отображения созданного двумерного массива.
void Print2DArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            System.Console.Write (array[i,j] + " ");
        }
        System.Console.WriteLine ();
    }
}

// Пишем метод для поиска элемента массива по введенным данным:
    void SearchedItem(int[,] array)
{
    int R = ReadInt("Введите позицию строки: ");
    int C = ReadInt("Введите позицию столбца: ");
    bool flag = false;
    for (int i =0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)
        {
            if (i == R && j == C)
            {
                flag = true;
                break;
            }
        }
    }

if (flag)
{
    // Знаю, что не совсем корректно совмещать нахождение элемента с выводом на печать, но
    // из-за крайней ограниченности во времени, я прибегла к данному упрощению ДЗ.

    System.Console.WriteLine ($"Введенным позициям строки '{R}' и столбца '{C}' соответствует элемент '{array [R,C]}'.");
}
else
{
    System.Console.WriteLine ($"Элемент с введенными позициями '{R}' и '{C}' не найден.");
}
}

int [,] MyArray = Create2DArray (4,6,0,10);
Print2DArray (MyArray);
SearchedItem(MyArray);


