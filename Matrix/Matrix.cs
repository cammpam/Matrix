using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        public int[,] MatrixArray { get; set; }
        public int ArrRow { get; set; }
        public int ArrColumn { get; set; }

        public Matrix(int row, int column)
        {
            MatrixArray = new int[row, column];
            ArrColumn = column;
            ArrRow = row;
        }

        //Creates random number for row & Column
        public void RandomNum()
        {
            Random val = new Random();
            for (int i = 0; i < ArrRow; i++)
            {
                for (int j = 0; j < ArrColumn; j++)
                {
                    MatrixArray[i, j] = val.Next(1, 10);
                }
            }
        }


        public void MtxAdd(int mxRow, int mxCol, int value)
        {
            // sets 0 for row and column of index of 0
            if (value == 0)
            {
                for (int i = 0; i < ArrRow; i++)
                {
                    MatrixArray[i, mxCol] = 0;
                }
                for (int j = 0; j < ArrColumn; j++)
                {
                    MatrixArray[mxRow, j] = 0;
                }
            }
            else
            {
                MatrixArray[mxRow, mxCol] = value;
            }
        }


        // Print our matrix in an easily viewed format
        public void Print()
        {
            for (int i = 0; i < ArrColumn; i++)
            {
                string currentLine = "";
                for (int j = 0; j < ArrRow; j++)
                {
                    currentLine += $"{MatrixArray[j, i]} ";
                }
                Console.WriteLine(currentLine);
            }
        }
    }
}
