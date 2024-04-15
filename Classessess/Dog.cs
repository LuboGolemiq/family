using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classessess
{
    public class Dog
    {
        public string name;
        public string breed;
        public int age;
        public double weight;

        public void canBark()
        {
            Console.WriteLine("Jaf,Jaf,Jaf");
        }
        public int GrowUp()
        {
            return ++age;
        }
    }
}
