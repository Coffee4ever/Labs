using System;
namespace LAB1
{
    class A
    {
        public A(B b, C c, J j) 
        {
            this.b = b;
            this.c = c;
            this.j = j;

            c.ci = 41;
        }
        ~A() { }

        public void mA() { Console.WriteLine("method of A"); }
        public B bA 
                {   set { Console.WriteLine("set b"); b = value; }
                    get { Console.Write("get b ->"); return b;  }
                }
        public C cA 
                {   set { Console.WriteLine("set c"); c = value; }
                    get{ Console.Write("get c ->"); return c;  }
                }
        public J jA 
                {   set { Console.WriteLine("set j"); j = value; }
                    get { Console.Write("get j ->"); return j; }
                }

       private B b = null;
       private C c = null;
       private J j = null;
    }

    class B  {
        public B(D d)
            {
                this.d = d;
            }
        ~B() { }
        public void mB() { Console.WriteLine(" method of B"); }
        public D dA
        {
            set { Console.WriteLine("set d"); d = value; }
            get { Console.Write("get d -> "); return d; }
        }
        private D d = null;
    }
    class C 
    {
        public C() { this.ci = 20;}
        public C(E e, F f, K k)
        {
            this.e = e;
            this.f = f;
            this.k = k;

            this.ci = 100;
        }
        ~C() { }
        public void mC() { Console.WriteLine("method of C"); }
        public E eA
        {
          set { Console.WriteLine("set e"); e = value; }
          get { Console.Write("get e ->"); return e; }
        }
        public F fA
        {
          set { Console.WriteLine("set f"); f = value; }
          get { Console.Write("get f ->"); return f; }
        }
        public K kA
        {
          set { Console.WriteLine("set k"); k = value; }
          get { Console.Write("get k ->"); return k; }
        }
        private E e = null;
        private F f = null;
        private K k = null;
        public int ci { set; get; } 
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
            K k = new K();
            D d = new D(); 

            E e = new E();

            F f = new F(); F f1 = new F();
            J j = new J();
            B b = new B(d);

            C c = new C(e, f, k);
            C c1 = new C();
            c1.eA = e;
            c1.fA = f;
            c1.kA = k;

            c.fA = f1;

            c.ci = 50;
            A a = new A(b, c, j);
            Console.Write(" c.ci = {0}  ", c.ci);   
            Console.Write(" a.cA.ci = {0}  ", a.cA.ci); 
            a.mA();
            a.bA.mB();
            a.cA.mC();
            a.jA.mJ();
           
            a.cA.eA.mE();
            a.cA.fA.mF();
            a.cA.kA.mK();

            a.bA.dA.mD();

        }
    }
}