// Двумерные массивы
/* Это массив,элементами которого являются одномерные массивы одинакового размера.
Двумерный массив = матрица, таблица.
Обращение к элементу - array[1][4] 
int[,] array = new int[3(количество строк), 5(количество столбцов)];
*/
/*
Задача 1: создать двумерный массив с размерами 3*5 состоящий из целыз чисел
*/

/*
int[,] matrix = new int[3, 5];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
*/

int [,] CreateMatrix (int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);