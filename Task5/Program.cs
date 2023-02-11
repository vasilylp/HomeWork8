// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//------------------------------Решение---------------------------------------

// int[,] FillMatrix(int rows, int cols)
// {
//     int[,] matrix = new int[rows, cols];
//     int temp = 1;
//     int i = 0;
//     int j = 0;
//     while (temp <= rows * cols)
//     {
//         matrix[i, j] = temp;
//         temp++;
//         if (i <= j + 1 && i + j < cols - 1)
//         {
//             j++;
//         }
//         else if (i < j && i + j >= rows - 1)
//         {
//             i++;
//         }
//         else if (i >= j && i + j > cols - 1)
//         {
//             j--;
//         }
//         else
//         {
//             i--;
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             System.Console.Write(matr[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] matrix = FillMatrix(4, 4);
// PrintMatrix(matrix);
//-------------------------------------------------------------------------------
/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] FillMatrixtoSpiral(int row, int col)
{
    int[,] array = new int[row, col];

    int Up = 0;    // Сужение сверху
    int Down = 0;  // Сужение снизу
    int Left = 0;  // Сужение слева
    int Right = 0; // Сужение справа

    // Переменные счетчики используемые в расчетах
    int k = 1; // Счетчик, который присваивает значение элемнетам массива
    int i = 0; // Координары строки
    int j = 0; // Координаты столбца

    while (k <= row * col)
    {
        array[i, j] = k;

        // Проверка возможности движения вправо
        if (i == Up && j < col - Right - 1)
            ++j; // производится движение по столбцу вправо

        // Проверка возможности движения вниз
        else if (j == col - Right - 1 && i < row - Down - 1)
            ++i; // производится движение по строкам вниз

        // Проверка возможности движения влево
        else if (i == row - Down - 1 && j > Left)
            --j; // производится движение по столбцу влево

        // Проверка возможности движения вверх
        else
            --i; // производится движение по строкам вверх

        // Сужение диапазона, если окружность заполнена
        if ((i == Up + 1) && (j == Left) && (Left != col - Right - 1))
        {
            ++Up;
            ++Down;
            ++Right;
            ++Left;
        }
        ++k; // Счетчик увеличен на 1
        // Цикл начинается заново
    }
    return array;
}

// Блок вывода элементов двумерного массива
void PrintArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); ++x)
    {
        for (int y = 0; y < array.GetLength(1); ++y)
        {
            System.Console.Write(array[x, y] + "\t");
        }
        System.Console.WriteLine();
    }
}

// Основной блок программы
int[,] SpiralArray = FillMatrixtoSpiral(4, 4);
PrintArray(SpiralArray);

