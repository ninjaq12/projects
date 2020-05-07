using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.Workers
{
    class SudokuFileReader
    {
        public int[,] ReadFile(string filename)
        {
            int[,] sudokuBoard = new int[9, 9];
            try
            {
                //0 4 0 0 0 0 1 7 9
                //0 0 2 0 0 8 0 5 4
                //0 0 6 0 0 5 0 0 8
                //0 8 0 0 7 0 9 1 0
                //0 5 0 0 9 0 0 3 0
                //0 1 9 0 6 0 0 4 0
                //3 0 0 4 0 0 7 0 0
                //5 7 0 1 0 0 2 0 0
                //9 2 8 0 0 0 0 6 0

                var sudokuBoardLines = File.ReadAllLines(filename);

                int row = 0;
                foreach (var sudokuBoardLine in sudokuBoardLines)
                {
                    string[] sudokuBoardLineElements = sudokuBoardLine.Split(' ').Take(9).ToArray();

                    int col = 0;
                    foreach (var sudokuBoardLineElement in sudokuBoardLineElements)
                    {
                        sudokuBoard[row, col] = Convert.ToInt16(sudokuBoardLineElement);
                        col++;                        
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while reading the file: " + ex.Message);
            }

            return sudokuBoard;
        }
    }
}
