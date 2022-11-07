using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class Demo
    {
        public int a;
        public void Test()
        {
            Console.WriteLine("Enter a number");
            this.a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(this.a);
        }


    }
}
