using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算BIM
{
    class Program
    {
        static void Main(string[] args)
        {
            int bmivalue = 703;
            string w, h0, h;
            double b;
          
                Console.WriteLine("请输入您的体重（磅):");
                w = Console.ReadLine();
                Console.WriteLine("请输入您的身高（英尺部分):");
                h0 = Console.ReadLine();
                Console.WriteLine("（英寸部分):");
                h = Console.ReadLine();
                double w1 = Convert.ToInt16(w);
                double h1 = Convert.ToInt16(h0) * 12 + Convert.ToInt16(h);
                b = w1 * bmivalue / (h1 * h1);
                if (w1 > 0 && h1 > 0)
                {
                    Console.WriteLine("您身体质量指数为:{0:F}", b);
                }
                else
                {
                    Console.WriteLine("您输入的数据错误！");
                }
            

        }
    }
}
