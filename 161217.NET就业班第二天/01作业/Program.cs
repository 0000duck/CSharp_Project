using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义父亲类Father(姓lastName, 财产property, 血型bloodType),
            //儿子Son类(玩游戏PlayGame方法),女儿Daughter类(跳舞Dance方法)，调用父类构造函数(:base())给子类字段赋值
            //Father f = new Sun("hong",10000,"O");
            //f.LastName = "dls";

            //定义汽车类Vehicle属性（brand(品牌),color（颜色））方法run，子类卡车(Truck) 
            //属性weight载重 方法拉货，轿车(Car) 属性passenger载客数量 方法载客
            //Truck t = new Truck("解放牌汽车","绿色",100000000);
            //t.LaHuo();

            //Car c = new Car("红旗轿车","黑车",5);
            //c.ZaiKe();

            //橡皮rubber鸭子、木wood鸭子、真实的鸭子realduck。三个鸭子都会游泳，
            //而橡皮鸭子和真实的鸭子都会叫，只是叫声不一样，橡皮鸭子“唧唧”叫，真实地鸭子“嘎嘎”叫，木鸭子不会叫.

            IBark bark =new XPDuck();//new RealDuck();new MuDuck();不行因为没有继承接口
            bark.Bark();
            Console.ReadKey();
        }
    }


    public  class Duck
    {
        public void Swim()
        {
            Console.WriteLine("鸭子们都会游泳,旱鸭子不会");
        }
    }
    interface IBark
    {
        void Bark();
    }

    class XPDuck : Duck, IBark
    {
        public void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }
    class RealDuck : Duck, IBark
    {
        public void Bark()
        {
            Console.WriteLine("真的鸭子嘎嘎叫");
        }
    }

    class MuDuck : Duck { }
    class Father
    {
        private string _lastName;
        private double _property;
        private string _bloodType;
        public string LastName { get; set; }
        public double Property { get; set; }
        public string BloodType { get; set; }
        public Father(string lastname, double property, string bloodtype)
        {
            this.LastName = lastname;
            this.Property = property;
            this.BloodType = bloodtype;
        }
    }
    class Sun : Father
    {
        public Sun(string lastname, double property, string bloodtype) : base(lastname, property, bloodtype)
        {
        }
        public void PlayGame()
        {
            Console.WriteLine("儿子可以玩游戏");
        }
    }
    class Daughter : Father
    {
        public Daughter(string lastname, double property, string bloodtype) : base(lastname, property, bloodtype)
        {
        }
        public void Dance()
        {
            Console.WriteLine("女儿可以跳舞");
        }
    }

    enum VehicalColor
    {
        Black,
        Red,
        Blue,
        White,
        Yellow
    }

    class Vehicle
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public Vehicle(string brand, string color)
        {
            this.Brand = brand;
            this.Color = color;
        }
        public void Run()
        {
            Console.WriteLine("是车都会跑");
        }
    }
    class Truck : Vehicle
    {
        public double Weight
        {
            get;
            set;
        }
        public Truck(string brand, string color, double weight) : base(brand, color)
        {
            this.Weight = weight;
        }

        public void LaHuo()
        {
            Console.WriteLine("卡车可以最多拉{0}KG的货", this.Weight);
        }
    }
    class Car : Vehicle
    {
        public int Passenger
        {
            get;
            set;
        }
        public Car(string brand, string color,int passenger) : base(brand, color)
        {
            this.Passenger = passenger;
        }
        public void ZaiKe()
        {
            Console.WriteLine("轿车可以拉{0}个人",this.Passenger);
        }
    }
}
