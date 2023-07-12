//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[,] Create2DArray(int rows, int cols) //Создание двумерного массива вещественных чисел
{
    return new double[rows, cols];
}

void Fill2DArray(double[,] array) //Заполнение двумерного массива вещественными числами
{
    int deviation = 100;
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = Math.Round((rnd.NextDouble() - 0.5) * 2 * deviation, 2);
}

void Print2DArray(double[,] array) //Вывод двумерного массива на экран
{
    Console.Write("Ваш массив: \n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

double[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray);
Print2DArray(myArray);
*/


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int InputNum(string message) //Ввод с клавиатуры
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols) //Создание двумерного массива
{
    return new int[rows, cols];
}

void Fill2DArray(int[,] array) //Заполнение двумерного массива
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = rnd.Next(-100, 101);
}

void Print2DArray(int[,] array) //Вывод двумерного массива на экран
{
    Console.Write("Ваш массив: \n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

void Location (int[,] array, int first, int second) //Поиск значения заданного элемента
{
    
    if (first < 0 | first > array.GetLength(0) | second < 0 | second > array.GetLength(1))
        Console.WriteLine("Элемент не существует \n");
    else
        Console.WriteLine($"Значение элемента массива = {array[first - 1, second - 1]}");
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray);
Print2DArray(myArray);

int pos1 = InputNum("Введите позицию в строке: ");
int pos2 = InputNum("Введите позицию в столбце: ");
Location(myArray, pos1, pos2);