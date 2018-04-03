using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17计算图形的面积和周长
{
    class Program
    {
        static void Main(string[] args)
        {
            //计算形状Shape(圆Circle，矩形Square ，正方形Rectangle)的面积、周长
            Shape shape = new Square(10,2);//new Circle(1);
            double s= shape.GetArea();
            double p = shape.GetPerimeter();
            Console.WriteLine("这个图形的面积是{0:0.00},周长是{1:0.00}",s,p);
            Console.ReadKey();
        }
    }
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    class Circle : Shape
    {
        public double R { get; set; }
        public Circle(double r)
        {
            this.R = r;
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }
    /// <summary>
    /// 矩形
    /// </summary>
    class Square : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Square(double width,double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double GetArea()
        {
            return this.Width * this.Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.Width + this.Height);
        }
    }

}
