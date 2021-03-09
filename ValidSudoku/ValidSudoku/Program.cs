using System;
using System.Collections.Generic;

namespace ValidSudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new char[][]
            {
                new char[] { '5','3','.','.','.','.','.','.','.'},
                new char[] { '6','.','.','.','.','.','.','.','.'},
                new char[] { '.','9','8','.','.','.','.','.','.'},
                new char[] { '8','.','.','.','.','.','.','.','.'},
                new char[] { '4','.','.','.','.','.','.','.','.'},
                new char[] { '7','.','.','.','.','.','.','.','.'},
                new char[] { '.','.','.','.','.','.','.','.','.'},
                new char[] { '.','.','.','.','.','.','.','.','.'},
                new char[] { '.','.','.','.','.','.','.','.','.'},
            };

            var s = new Solution();
            Console.WriteLine(s.validSudoku(board));
        }
        public class Solution
        {
            
            public bool validSudoku(char[][] board)
            {
                int boardSize = 9;

                for (int i = 0; i < boardSize; i++) // 0 -9
                {
                    List<char> rowNums = new List<char>();
                    List<char> columnNums = new List<char>();
             

                    for (int j = 0; j < boardSize; j++)  // 0 -9
                    {
                        char rowChar = board[i][j]; // row = i, column = j
                        if ( rowChar != '.')
                        {
                            if (rowNums.Contains(rowChar)) return false;
                            else rowNums.Add(rowChar);
                        }

                        char colChar = board[j][i]; // row = j, column = i
                        if ( colChar != '.')
                        {
                            if (columnNums.Contains(colChar)) return false;
                            else columnNums.Add(colChar);
                        }
                    }
                }

                var blockArray = new int[][]
                {
                        new int [] {0,1,2},
                        new int [] {3,4,5},
                        new int [] {6,7,8}
                };
                for (int j = 0; j < 3; j++) // j index of 1st inner array in blockArray
                {
                    for (int k = 0; k < 3; k++) // k index of 2nd inner array in blockArray
                    {
                        List<char> blockNums = new List<char>();
                        
                        for (int l = 0; l < 3; l++) // l index of nums of 1st inner array
                        {
                            for ( int m = 0; m < 3; m++)  // m index of nums of 2nd inner array
                            {
                                char blockChar = board[blockArray[j][l]][blockArray[k][m]];
                                
                                if (blockChar != '.')
                                {
                                    if (blockNums.Contains(blockChar)) return false;
                                    else blockNums.Add(blockChar);
                                }
                            }
                        }
                    }
                }
                return true;
            }
        }
    }
}
