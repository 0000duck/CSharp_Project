using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09移动存储设备
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileDisk md = new MobileDisk();
            MP3 mp3 = new MP3();
            UDisk u = new UDisk();
            Mobile m = new Mobile();

            Computer cpu = new Computer();
            //cpu.CpuRead(md);//传参实现读写
            //cpu.CpuWrite(md);

            cpu.MS = m; //mp3;//将MP3插到了电脑上
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
    class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }
    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("优盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("优盘在写入数据");
        }
    }
    class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3在播放音乐上");
        }
    }
    class Mobile : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("手机在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("手机在写入数据");
        }
    }
    class Computer
    {
        public MobileStorage MS//自动属性 最终数据给字段
        {
            get;
            set;
        }
        public void CpuRead()
        {
            this.MS.Read();
        }
        public void CpuWrite()
        {
            this.MS.Write();
        }
        //public void CpuRead(MobileStorage ms)//传父类 因为子类已经重写了 已经实现了多台 你穿的是弗雷 但给你的是子类 最终执行的是子类的函数
        //{
        //    ms.Read();
        //}
        //public void CpuWrite(MobileStorage ms)
        //{
        //    ms.Write();
        //}
    }
}
