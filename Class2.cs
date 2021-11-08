using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Matrix
    {
        public double[,] value = new double[3, 3];
        public virtual void Enter()
        {
            Console.WriteLine("write matrix");
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int j = 0; j < value.GetLength(1); j++)
                {
                    value[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }
        public void Log()
        {
            string sum = "";
            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int j = 0; j < value.GetLength(1); j++)
                {
                    sum += $" {value[i, j]}";
                }
            }
            Console.WriteLine(sum);
        }
        
    }
    class UpperTriangularMatrix : Matrix
    {
        public override void Enter()
        {
            Console.WriteLine("write matrix");
            var mass = new int[,] { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 1 }, { 1, 2 }, { 2, 2 } };
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                value[mass[i, 0], mass[i, 1]] = double.Parse(Console.ReadLine());
            }
        }
    }
    class IdentityMatrix : Matrix
    {
        public override void Enter()
        {
            value[0, 0] = 1;
            value[1, 1] = 1;
            value[2, 2] = 1;
        }
    }
    class MatrixCalculate : Matrix {
        public void Calculate()
        {
            var toReturn =
                 value[0, 0] * value[1, 1] * value[2, 2] +
                 value[0, 1] * value[1, 2] * value[2, 0] +
                 value[0, 2] * value[1, 0] * value[2, 1] +
                 value[0, 2] * value[1, 1] * value[2, 0] +
                 value[0, 1] * value[1, 0] * value[0, 2] +
                 value[0, 0] * value[1, 2] * value[2, 1];
            Console.WriteLine(toReturn);
        }
    }
    class UpperTriangularMatrixCalculate :UpperTriangularMatrix{
        public void Calculate()
        {
            var result = value[0, 0] + value[1, 1] + value[2, 2];
            Console.WriteLine(result);
        }
    }
    class IdentityMatrixCalculate: IdentityMatrix
    {
        public void Calculate()
        {
            Console.WriteLine(1);
        }
    }
}
