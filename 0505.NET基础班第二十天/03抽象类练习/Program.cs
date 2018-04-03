using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Write()
        {
            throw new NotImplementedException();
        }
    }
    public class Computer
    {
        public MobileStorage MS
        {
            get;
            set;
        }

        public void CPURead()
        {
            this.MS.Read();
        }
        public void CUPWrite()
        {
            this.MS.Write();
        }
    }
}
