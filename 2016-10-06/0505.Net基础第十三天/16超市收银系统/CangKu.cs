using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16超市收银系统
{
    class CangKu
    {
        //存储货物 存东西(用集合存，不限制长度)

        //下面这样存麻烦,不如直接存父类
        //List<SamSung> listSam = new List<SamSung>();
        //List<Acer> listAcer = new List<Acer>();
        //List<JiangYou> listJiangYou = new List<JiangYou>();
        //List<Banana> listBanana = new List<Banana>();

        //存父类 所有的子类都可以当做父类去看 由里氏转换得知 子类可以赋值给父类 （但这样存不好找，表示把各种商品堆到一块了）
        //List<ProductFather> list0 = new List<ProductFather>();//给它添加数据的时候 可以直接把货物扔里面去 三星 酱油...缺点就是取的时候很麻烦
        List<List<ProductFather>> list = new List<List<ProductFather>>();//给它添加商品添加的是货架而不是商品 list0和list都代表仓库    货架是货物的集合

        /// <summary>
        /// 向用户展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)//item是每一个货架
            {
                Console.WriteLine("我们超市有: "+item[0].Name+","+"\t"+"有"+item.Count+"个"+"\t"+"每个"+item[0].Price+"元");//item[0]第一个商品
            }
        }

        //list[0]存储Acer电脑
        //list[1]存储三星手机
        //list[2]存储酱油
        //list[3]存储香蕉

        /// <summary>
        /// 当创建仓库对象的时候 向仓库中添加货架  这是一个构造函数（长裤创建时就调用这四个货架，此时还没货物）
        /// </summary>
        public CangKu()
        {
            list.Add(new List<ProductFather>());//添加一个泛型集合对象 添加的是货架
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">进货的类型</param>
        /// <param name="count">货物的数量</param>
        public void JInPros(string strType,int count)//要知道两件事 你来了多少货 来了多少个。在网仓库放的时候一个一个放的 所以头发弄过一个循环
        {
            for (int i = 0; i < count; i++)//货物可能有很多，通过循环去加
            {
                switch (strType)//由于有四种货物类型 所以对你的货物类型进行多条件的判断
                {
                    case "Acer":list[0].Add(new Acer(Guid.NewGuid().ToString(),4000,"宏碁"));//如果是宏碁的话 就创建一个宏碁电脑的对象 放到宏碁的货架上
                        break;
                    case "SamSung":
                        list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "棒之手机"));
                        break;
                    case "Banana":
                        list[2].Add(new Banana(Guid.NewGuid().ToString(), 10, "大香蕉"));
                        break;
                    case "JiangYou":
                        list[3].Add(new JiangYou(Guid.NewGuid().ToString(), 5, "老抽酱油"));
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 从仓库中提取货物
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public ProductFather[] QuPros(string strType,int count)//返回 ProductFather
        {
            ProductFather[] pros = new ProductFather[count];//从仓库里面提货物放到数组里面去返回   通过for循环给pros赋值
            for (int i = 0; i <pros.Length; i++)
            {
                switch (strType)
                {
                    //理论上 在拿之前应该对第一个货架上的货物做一个判断
                    case "Acer":
                        //if (list[0].Count == 0) { }
                        pros[i]=list[0][0];//list[0]是一个集合(放宏碁笔记本的货架)list[0][0]（货架上的第一个笔记本）返回一个父类类型。拿完后放到数组里面
                        list[0].RemoveAt(0);//拿走一个
                        break;
                    case "SamSung":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }
            return pros;
        }
    }
}
