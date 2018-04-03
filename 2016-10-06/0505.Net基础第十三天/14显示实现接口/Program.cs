using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //显示实现接口就是为了解决方法的重名问题
            IFlyable fly = new Bird();
            fly.Fly();
            Bird bird = new Bird();
            bird.Fly();

            Console.ReadKey();
        }
    }

    //类中的修饰符默认为private 接口里面默认为public
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟飞会");
        }
        /// <summary>
        /// 显示实现接口
        /// </summary>
        void IFlyable.Fly() //这个Fly()是接口的
        {
            Console.WriteLine("我是接口的飞");
        }

    }

    public interface IFlyable
    {
        void Fly();
    }
}
