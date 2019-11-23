using System;
namespace LAB3
{
    public class A
    {
	public A()
	{
	    Console.WriteLine("constructor A");
	    this.size = 0;
	}
	~A() { Console.WriteLine("destructor ~A "); }
	protected int size { set; get; }
	public virtual int fm() { return this.size + 1000; }
    }
    
    public class B : A
    {
	public B()
	{
	    Console.WriteLine("constructor B ");
	    this.size = 10;
	}
	~B() { Console.WriteLine("destructor ~B "); }
	public override int fm() { return this.size + 100; }
    }
    public class C : A
    {
	public C()
	{
	    Console.WriteLine("constructor C ");
	    this.size = 20;
	}
	~C() { Console.WriteLine("distructor C"); }
	public override int fm() { return this.size +200; }
    }
	
    public class J : A
    {
	public J()
	{
	    Console.WriteLine("constructor J ");
	    this.size = 30;
	}
	~J() { Console.WriteLine("distructor J"); }
	public override int fm() { return this.size + 300; }
    }
	
    public class D : B
    {
	public D()
	{
	    Console.WriteLine("constructor D ");
	    this.size = 40;
	}
	~D() { Console.WriteLine("distructor D"); }
	public override int fm() { return this.size + 400; }
    }
	
    public class E : C
    {
	public E()
	{
	    Console.WriteLine("constructor E ");
	    this.size = 50;
	}
	~E() { Console.WriteLine("distructor E"); }
	public override int fm() { return this.size + 400; }
    }

    public class F : C
    {
	public F()
	{
	    Console.WriteLine("constructor F ");
	    this.size = 60;
	}
	~F() { Console.WriteLine("distructor F"); }
	public override int fm() { return this.size + 500; }
    }

    public class K : J
    {
	public K()
	{
	    Console.WriteLine("constructor K ");
	    this.size = 70;
	}
	~K() { Console.WriteLine("distructor K"); }
	public override int fm() { return this.size + 600; }
    }

    class Program
    {
	static void Main()
	{
	    A a = new A();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );
	    a = new B();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );
	    a = new C();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );
	    a = new J();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );
	    a = new D();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );
	    a = new E();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );
	    a = new F();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );
	    a = new K();
	    Console.WriteLine(" a.fm() = {0}", a.fm() );

	    if (a is K)
	    {
		Console.WriteLine(" a is K");
	    }
	    K k = new K();
	    k.fm();
	}
    }
}
