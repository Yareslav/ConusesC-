using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Cone
    {
        protected const double Pi = 3.14;
        protected double height;
        protected double downRadius;
        public virtual void Enter()
        {
            Console.WriteLine("get volume of cone");
            Console.WriteLine("write its height");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("write its down radius");
            downRadius = double.Parse(Console.ReadLine());
            CalculateVolume();
        }
        public virtual void CalculateVolume()
        {
            Console.WriteLine(Pi * height * Math.Pow(downRadius, 2) / 3);
        }
    }
    class Frustum : Cone
    {
        private double upRadius;
        public override void Enter()
        {
            Console.WriteLine("get volume of cone");
            Console.WriteLine("write its height");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("write its down radius");
            downRadius = double.Parse(Console.ReadLine());
            Console.WriteLine("write its up radius");
            upRadius = double.Parse(Console.ReadLine());
            CalculateVolume();
        }
        public override void CalculateVolume()
        {
            Console.WriteLine(Pi * height * (Math.Pow(upRadius, 2) + upRadius * downRadius + Math.Pow(downRadius, 2)));
        }
    }
}
