using System;
namespace LAB1
{
    class A
    {
        public A() { c.ci = 44;}
        ~A() { }

        public void mA() { Console.WriteLine("method of A"); } 

        public B bA { get { Console.Write("get b ->"); return b; }  }
        public C cA { get { Console.Write("get c ->"); return c; }  }
        public J jA { get { Console.Write("get j ->"); return j; }  }

        private B b = new B();
        private C c = new C();
        private J j = new J();
    }
    class C 
    {
        public C() { this.ci = 20;}
        ~C() { }
        public void mC() { Console.WriteLine("method of C"); }
        public E eA { get { Console.Write("get e ->"); return e; } }
        public F fA { get { Console.Write("get f ->"); return f; } }
        public K kA { get { Console.Write("get k ->"); return k; } }
        private E e = new E();
        private F f = new F();
        private K k = new K();
        public int ci { set; get; } 
    }

    class B  
    {
        public B () { }
        ~B() { }
        public void mB() { Console.WriteLine(" method of B"); }
        public D dA { get { Console.Write("get d -> "); return d; } }
        private D d = new D();
    }
    class E {
      public E() { }
        ~E() { }
      public void mE() { Console.WriteLine(" method of E"); }
    }

    class F {
      public F() { }
      ~F() { }
      public void mF() { Console.WriteLine(" method of F");}
    }

    class J {
      public J() { }
      ~J() { }
      public void mJ() { Console.WriteLine(" method of J"); }      
    }

    class K {
      public K() { }
      ~K() { }
      public void mK() {Console.WriteLine(" method of K");}
    }
    class D {
      public D() { }
      ~D() { }
      public void mD() {Console.WriteLine(" method of D");}
    }
    class Program
    {
        static void Main()
        {
            A a = new A(); A a1 = new A();
            a.mA();
            a.bA.mB();
            a.cA.mC();
            a.jA.mJ();

            a.bA.dA.mD();
            
            a.cA.eA.mE();
            a.cA.fA.mF();
            a.cA.kA.mK();
            Console.ReadKey();
        }
    }
}