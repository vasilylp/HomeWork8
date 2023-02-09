// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//--------------------------------Решение------------------------------------------------------

//-----------------1.Создание трехмерного массива--------------------------------

int[,,] CreateMatrix(int x, int y, int z)
{
              Random rand = new Random();
              int[,,] matrixZ = new int[x, y, z];
              for (int i = 0; i < x; i++)
              {
                            for (int j = 0; j < y; j++)
                            {
                                          for (int k = 0; k < z; k++)
                                          {
                                                        matrixZ[i, j, k] = rand.Next(0, 10);
                                          }

                            }
              }
              return matrixZ;

}
//---------------------2.Печать созданного массива с индексами каждого элемента ----------------

void PrintMatrix(int[,,] matrixZ)
{
              System.Console.WriteLine($"Массив размером: {matrixZ.GetLength(0)} x {matrixZ.GetLength(1)} x {matrixZ.GetLength(2)}");
              for (int k = 0; k < matrixZ.GetLength(2); k++)
              {
                            for (int i = 0; i < matrixZ.GetLength(0); i++)
                            {
                                          System.Console.WriteLine();
                                          for (int j = 0; j < matrixZ.GetLength(1); j++)
                                          {
                                                        System.Console.Write($"{matrixZ[i, j, k]} ({i},{j},{k}) ");
                                          }

                            }
                            System.Console.WriteLine();
              }
}

//------------------------------Вызов методов --------------------------------------------

int[,,] matrZ = CreateMatrix(3, 2, 3);
PrintMatrix(matrZ);
System.Console.WriteLine();