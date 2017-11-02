using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ORIGINAL [10,10] MATRIX: ");
            Console.WriteLine();
            Matrix myMatrix = new Matrix(10, 10);
            myMatrix.RandomNum();
            myMatrix.Print();

            Console.WriteLine();

            Console.WriteLine("NEW [10,10] MATRIX WITH 0: ");

            Console.WriteLine();

            myMatrix.MtxAdd(5, 5, 0);
            myMatrix.Print();
            Console.Read();

        }
    }
}
