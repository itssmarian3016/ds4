using System;

namespace Laboratorio8_6
{
    class A
    {
        public virtual void Info() => Console.WriteLine("A.Info()");
    }

    class B : A
    {
        public sealed override void Info() => Console.WriteLine("B.Info() (sealed)");
    }

    class Program
    {
        static void Main()
        {
            A a = new A();
            A b = new B();
            a.Info();
            b.Info();
            Console.ReadKey();
        }
    }
}