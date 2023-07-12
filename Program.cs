//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


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