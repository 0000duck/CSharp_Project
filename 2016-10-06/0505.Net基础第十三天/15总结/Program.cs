using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15总结
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么时候用虚方法实现多态？
            //什么时候用抽象类来实现？
            //什么时候用接口来实现多态？

            //当在我提供你的几个类当中，如果说你能够抽象出来一个父类，并且这个父类当中必须写上这几个字类当中共有的方法，然后你还不知道如何去写这个方法，此时用抽象类去做这个多态。
            //反之。抽象出来的这个父类的这个方法可以写，并且也需要创建这个父类的对象，此时用虚方法。
            //这几个类里面你根本就找不到父类，但是他们都有一个共同的行为，共同的能力，这个时候拿接口实现多态.(鸟类和飞机都会飞)

            //真的鸭子会游泳  木头鸭子不会游泳 橡皮鸭子会游泳
        }
    }
    public class RealDuck : ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("真的鸭子靠翅膀游泳");
        }
    }

    public class MuDuck
    {

    }

    public class XPDuck : ISwimming
    {

        public void Swim()
        {
            Console.WriteLine("橡皮鸭子飘着游泳");
        }
    }

    public interface ISwimming
    {
        void Swim();
    }
}
