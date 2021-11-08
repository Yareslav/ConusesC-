using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task1
{
    class Point {
        public int x;
        public int y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Square
    {
        public Point[] mass=new Point[4];
        public Square()
        {
            Console.WriteLine("write x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("write y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("write size length");
            int sizeLength = int.Parse(Console.ReadLine());
            this.FillData(x,y,sizeLength);
            while (true)
            {
                var key = (int)Console.ReadKey().Key;
                if (key == (int)ConsoleKey.RightArrow) this.Move("right");
                else if (key ==(int)ConsoleKey.LeftArrow) this.Move("left");
            }
        }
        public void FillData(int x,int y,int sizeLength)
        {
            var A = new Point(x, y);
            var B = new Point(x + sizeLength, y);
            var C = new Point(x, y + sizeLength);
            var D = new Point(x + sizeLength, y + sizeLength);
            mass[0] = A;
            mass[1] = B;
            mass[2] = C;
            mass[3] = D;
        }
        public void Log()
        {
            Console.WriteLine("square length");
            foreach (var item in mass)
            {
                Console.WriteLine(item.x);
                Console.WriteLine(item.y);
            }
        }
        public virtual void Move(string direction)
        {
            Console.WriteLine("you move "+direction);
            foreach (var item in mass)
            {
                if (direction == "right") item.x++;
                else item.x--;
            }
            this.Log();
        }
    }
    class RotateSquare : Square {
        public override void  Move(string direction)
        {
            Console.WriteLine("you rotate " + direction);
            if (direction=="right") {
                mass[0].x = mass[1].x;
                mass[1].y = mass[2].y;
                mass[2].x = mass[3].x;
                mass[3].y = mass[0].y;
            }
            else {
                mass[0].y = mass[3].y;
                mass[1].x = mass[0].x;
                mass[2].y = mass[1].y;
                mass[3].x = mass[2].x;
            }
            this.Log();
        }
    }
}
