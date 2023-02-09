// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//-------------------------Решение-------------------------------------------------
//-----------------1.Создание двумерного массива--------------------------------

int[,] CreateMatrix(int rows, int cols)
{
              Random rand = new Random();
              int[,] matrix = new int[rows, cols];
              for (int i = 0; i < rows; i++)
              {
                            for (int j = 0; j < cols; j++)
                            {
                                          matrix[i, j] = rand.Next(0, 10);
                            }
              }
              return matrix;

}
//---------------------2.Печать созданного массива--------------------------------------

void PrintMatrix(int[,] matrix)
{
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                          System.Console.Write(matrix[i, j] + "\t");
                            }
                            System.Console.WriteLine();
              }
}

//--3.Проверяем условие равенства количества столбцов одного массива с количеством строк другого--

bool CheckSizeMatrix(int[,] matrixA, int[,] matrixB)
{
              if (matrixA.GetLength(0) == matrixB.GetLength(1) && matrixA.GetLength(1) == matrixB.GetLength(0))
              {
                            return true;
              }
              return false;

}
//-----------4.Перемножаем массивы если условие выполняется, результат помещаем в новый массив---

int[,] NewMatrix(int[,] matrixA, int[,] matrixB)
{
              int[,] newMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(0)];

              for (int i = 0; i < matrixA.GetLength(0); i++)
              {
                            for (int k = 0; k < matrixB.GetLength(1); k++)
                            {
                                          int sumRow = 0;
                                          for (int j = 0; j < matrixA.GetLength(1); j++)
                                          {
                                                        sumRow += (matrixA[i, j] * matrixB[j, k]);
                                          }
                                          newMatrix[i, k] = sumRow;

                            }

              }
              return newMatrix;

}


//------------------------------Вызов методов --------------------------------------------

int[,] matrA = CreateMatrix(3, 2);
PrintMatrix(matrA);
System.Console.WriteLine();
int[,] matrB = CreateMatrix(2, 3);
PrintMatrix(matrB);

System.Console.WriteLine();
if (CheckSizeMatrix(matrA, matrB))
{
              System.Console.WriteLine("Результирующий массив :");
              PrintMatrix(NewMatrix(matrA, matrB));
}
else
{
              System.Console.WriteLine("Массивы нельзя перемножить!\n" +
              "Количество строк одного массива должно быть равно количеству столбцов другого\n" +
              "а количество столбцов этого массива должно быть равно количеству строк другого.\n" +
              "Введите параметры соответствующие условию умножения массивов ");
}
System.Console.WriteLine();


