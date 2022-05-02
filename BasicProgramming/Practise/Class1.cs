using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.Practise
{
    public class Class1: IClass1, IClass2
    {
        public void fun()
        {
            Console.WriteLine("Hello, Lets have fun!!!");
        }
    }
}
