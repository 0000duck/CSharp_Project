using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态求矩形的面积和周长以及圆形的面积和周长
            //多态好处：通用的代码   屏蔽了各个类型之间的差异性
            Shape sharp = new Circle(5);//new Rectangle(4,5);
            double area= sharp.GetArea();
            double perimeter = sharp.GetPerimter();
            Console.WriteLine("这个形状的面积是{0}，周长是{1}",area,perimeter);
            Console.ReadKey(); 
            
        }
    }
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimter();
    }

    public class Rectangle : Shape
    {
        private double _length;
        private double _width;
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle(double length,double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()
        {
            return this.Length * this.Width;
        }

        public override double GetPerimter()
        {
            return (this.Length + this.Width) * 2;
        }
    }

    public class Circle : Shape
    {
        //求圆的面积3.14*r*r
        private double _r;
        //拿属性存半径
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        //我想在创建圆形对象的时候，就把圆的半径传进去.故写一个构造函数
        public Circle(double r)
        {
            this.R = r;//赋值给属性
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimter()
        {
            return 2 * Math.PI * this.R;
        }
    }

}
