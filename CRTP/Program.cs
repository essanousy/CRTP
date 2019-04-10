using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRTP
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Base<T>
        where T : Base<T>, new()
    {
        protected Base()
        {
        }

        public static T Instance => new T();
    }

    public class Class1 : Base<Class1>
    {
    }

    public class Class2 : Base<Class2>
    {
    }
}
