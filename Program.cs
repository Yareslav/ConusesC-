using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Task1;
using Task2;
using Task3;
namespace ConsoleApplication1
{
    class Program
    {
        static void Task1()
        {
            new Square();
            new RotateSquare();
        }
        static void Task2()
        {
            new Cone().Enter();
            new Frustum().Enter();
        }
        static void Task3()
        {
            var identityMatrix = new IdentityMatrixCalculate();
            identityMatrix.Enter();
            identityMatrix.Log();
            identityMatrix.Calculate();
            identityMatrix.Calculate();
            var upperTriangleMatrix = new UpperTriangularMatrixCalculate();
            upperTriangleMatrix.Enter();
            upperTriangleMatrix.Log();
            upperTriangleMatrix.Calculate();
            var matrix = new MatrixCalculate();
            matrix.Enter();
            matrix.Log();
            matrix.Calculate();
        }
        static void Main()
        {
            //Task1();
            //Task2();
            //Task3();
            Console.ReadLine();
        }
    }
}
