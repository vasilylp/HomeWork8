// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//---------------------Решение------------------------------------------------
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
//-------------------------3.Сортировка массива по убыванию ------------------------------

int[,] SortMatrix(int[,] matrix)
{
              int[,] sortMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                          int maxNumberR = matrix[i, j];
                                          int k = j;
                                          int temp = 0;
                                          while (k < matrix.GetLength(1))
                                          {
                                                        if (matrix[i, k] > maxNumberR)
                                                        {
                                                                      temp = maxNumberR;
                                                                      maxNumberR = matrix[i, k];
                                                                      matrix[i, k] = temp;
                                                        }
                                                        k++;
                                          }
                                          sortMatrix[i, j] = maxNumberR;
                            }

              }
              return sortMatrix;
}
//----------------------------Вызов методов-------------------------------------------------


int[,] matr = CreateMatrix(4, 3);
PrintMatrix(matr);

System.Console.WriteLine();
PrintMatrix(SortMatrix(matr));
