using System;   //引入命名空间
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkPlace//命名空间
{
    class Readkey//这个是Readkey类
    {
        static void Main(string[] args)//这个是main方法
        {
            Console.WriteLine("hello world!");//打印一行

            //Console.ReadKey();//读取键
            /*
             * ctrl+k+c快捷注释
             * ctrl+k+u取消注释
             * 注释中不可以有空格
             */
            //一行一条语句
            //Console.Write("hello world");//write打印不会换行
            Console.WriteLine("kss说：\"what is \\n\"");
            Console.WriteLine("hello \n\tworld");
            /*
             * \n：换行
             * \t：水平制表符
             */

        }
        
    }
}
