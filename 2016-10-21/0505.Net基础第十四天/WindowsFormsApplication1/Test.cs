using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    //静态类 资源共享  不能创建对象
    public static class Test
    {
        public static Form1 _fr1Test;//静态字段 只能存Form1类型的
    }
}
