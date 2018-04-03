using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16超市收银系统
{
    class SuperMarket
    {
        //创建仓库对象   仓库里面有货架
        CangKu ck = new CangKu();
        /// <summary>
        /// 构造函数 当我创建超市对象的时候 给仓库的货架上导货物
        /// </summary>
        public SuperMarket()
        {
            ck.JInPros("Acer",1000);
            ck.JInPros("SamSung",1000);
            ck.JInPros("JiangYou",1000);
            ck.JInPros("Banana",1000);
        }

        /// <summary>
        /// 更用户交互的过程
        /// </summary>
        public void AskByuing()
        {
            Console.WriteLine("欢迎光临，请问您需要点什么？");
            Console.WriteLine("我们有 Acer、SamSung、JiangYou、Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("您需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());
            if (count<0)
            {
                Console.WriteLine("输入有误，请重新输入！");
            }
            //去仓库取货物
            ProductFather[] pros= ck.QuPros(strType, count);
            //下面该计算价钱了
            double realMoney = GetMoney(pros);
            Console.WriteLine("您总共应付{0}元",realMoney);
            Console.WriteLine("请选择您的打折方式1--不打折 2--打九折 3--打85折 4--买300送50 5--买500送100");//为了提高程序的可扩展性 提取父类（抽象打折方法）
            string input = Console.ReadLine();
            //根据简单工厂的设计模式 根据用户的输入获得一个打折对象
            CalFather cal = GetCal(input); //返回的cal是父类类型
            double totalMoney = cal.GetTotalMoney(realMoney);
            Console.WriteLine("打完折后，您应付{0}元",totalMoney);
            Console.WriteLine("以下是您的购物信息");
            foreach (var item in pros)
            {
                Console.WriteLine("货物名称:" + item.Name + "," + "\t" + "货物单价:" + item.Price + "," + "\t" + "货物编号：" + item.ID);
            }

        }

        //简单工厂设计模式 
        /// <summary>
        /// 根据用户的选择打折方式返回一个打折对象
        /// </summary>
        /// <param name="input">用户的选择</param>
        /// <returns>返回的父类对象 但是里面装的是子类对象</returns>
        public CalFather GetCal(string input)//根据用户的输入返回一个对象 返回的是父类类型 但里面装的是子类对象
        {
            CalFather cal = null;
            switch (input)
            {
                case "":cal = new CalNormal();
                    break;
                case "2":cal = new CalRate(0.9);
                    break;
                case "3":cal = new CalRate(0.85);
                    break;
                case "4":cal = new CalMN(300,50);
                    break;
                case "5":cal = new CalMN(500,100);
                    break;
                default:
                    break;
            }
            return cal;
        }


        /// <summary>
        /// 根据用户买的货物计算总价钱
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }
    }
}
