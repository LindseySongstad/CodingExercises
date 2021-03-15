using System;

namespace RotateImage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9}
            };

            //Output: 
            //[[7,4,1],
            //[8,5,2],
            //[9,6,3]]

            printMatrix(matrix);
            
            Rotate(matrix);

            printMatrix(matrix);

            static void Rotate(int[][] matrix)
            {
                int size = matrix.Length;
                int[][] temp = new int[size][];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = new int[size];
                    for (int j = 0; j < size; j++)
                    {
                        temp[i][j] = matrix[i][j];
                    }
                }
                
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        int newCol = size - i - 1;
                        matrix[j][newCol] = temp[i][j]; 
                    }
                }
            }

            static void RotateInPlace(int[][] matrix)
            {
                int size = matrix.Length;
                int startingDex = 0;

                // for 1/2 size times rotate outer layer starting with corners, size-- , startingDex++
                    // size-1 times per layer 0,0 - 0,size-1  
                        // 4 moves, each corner...



            }

            static void printMatrix(int[][] matrix)
            {
                
                foreach (int[] i in matrix)
                {
                    Console.WriteLine();
                    foreach (int j in i)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
