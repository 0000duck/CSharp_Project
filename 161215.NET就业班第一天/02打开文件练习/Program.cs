using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02打开文件练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开的文件所在的路径");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开文件的名字");
            string fileName = Console.ReadLine();

            //通过简单工厂设计模式返回父类
            BaseFile bf = GetFile(filePath,fileName);
            if (bf!=null)
            {
                bf.OpenFile();
            }
            Console.ReadKey();
        }

        static BaseFile GetFile(string filePath, string fileName)
        {
            BaseFile bf = null;
            string strExtension = Path.GetExtension(fileName);
            switch (strExtension)
            {
                case ".txt":
                    bf = new TxtFile(filePath,fileName);
                    break;
                case ".mp3":
                    bf = new MP3FFile(filePath,fileName);
                    break;
                case ".mp4":
                    bf = new MP4File(filePath,fileName);
                    break;
                case ".avi":
                    bf = new AviFile(filePath,fileName
                        );
                    break;
                default:
                    break;
            }
            return bf;
        }

        class BaseFile
        {
            //字段、属性、构造函数、函数、索引器
            //字段     存储数据
            //属性     保护字段
            //构造函数 用于给对象进行初始化(给对象的每个属性进行赋值)
            //函数     描述对象的行为
            //索引器
            private string _filePath;
            /// <summary>
            /// 属性
            /// </summary>
            public string FilePath//封装属性的快捷键 ctrl+R+E 
            {
                get
                {
                    return _filePath;
                }

                set
                {
                    _filePath = value;
                }
            }
            //自动属性  prop+两下tab  属性的本质就是两个函数 get set
            public string FileName { get; set; }

            public BaseFile(string filePath, string fileName)
            {
                this.FilePath = filePath;
                this.FileName = fileName;
            }

            //设计一个函数 用来打开指定的文件
            public void OpenFile()
            {
                //指定使用进程时使用的一组值
                ProcessStartInfo psi = new ProcessStartInfo(this.FilePath+"\\"+FileName);
                //创建进程对象
                Process pro = new Process();
                pro.StartInfo = psi;
                pro.Start();
            }
        }

        class TxtFile : BaseFile
        {
            //因为子类会默认调用父类无参的构造函数
            public TxtFile(string filePath, string fileName) : base(filePath, fileName)
            {
            }
        }
        class MP3FFile : BaseFile
        {
            public MP3FFile(string filePath, string fileName) : base(filePath, fileName)
            {
            }
        }
        class MP4File : BaseFile
        {
            public MP4File(string filePath, string fileName) : base(filePath, fileName)
            {
            }
        }
        class AviFile : BaseFile
        {
            public AviFile(string filePath, string fileName) : base(filePath, fileName)
            {
            }
        }
    }
}
