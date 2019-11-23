using System;

namespace LAB4
{
	public interface J
	{	
		void mJ();
	}
	
	public interface D 
	{
		int fD();
	}
	
	public interface B : D
	{
		int fB();
	}	

	abstract public class E
	{
		public abstract int fE(); 
	}
	
	public class C : E
	{
		public C() { this.size = 10; this.color = 77; }
		~C() { }
		protected int size { set; get;}
		public int color {set; get; }
		public virtual int f()
		{
			Console.WriteLine("class C f() ");
			return 90;
		}
		public override int fE()
		{
			return 0;
		}
	}


	public class F : C 
	{
		public F() {this.speed = 33; }
		~F() { }
		public int speed {set; get; }
		public int fF()
		{
			Console.WriteLine("class F fF() ");
			return base.f() + 10;
		}
	}
	public class K : C
	{
		public K(){ this.size = 10; this.color = 77; }
		~K(){ }
		public override int f()
		{
			Console.WriteLine("class K f() ");
			return 90;
		}
		public int Kf()
		{
			Console.WriteLine("class K Kf() ");
			return this.size * this.color;
		}
	}		
	public class A : C, B, J
	{
		public A(){ this.size = 20; this.color = 55;}
		~A() { }
		public override int f()
		{
			Console.WriteLine("class A f() ");
			return this.size * this.color;
		}
		public override int fE()
		{
			return 5;
		}
		public void mJ()
		{
			this.size += 10;
		}
		public int fD()
		{
			Console.WriteLine("class A fD()");
			return this.size + 100;
		}
		public int fB()
		{
			return this.color + 50;
		}
	}
	class Program
	{
		static void Main(){
			B b = null;
			b = new A();
			Console.WriteLine("b.fB() = {0}", b.fB());
			Console.WriteLine("b.fD() = {0}", b.fD());
		
			J j = null;	
			j = new A();

			A a = new A();
			a.f();
			
			C c = new C();
			Console.WriteLine(" class C c.f() {0}", c.f());
			Console.WriteLine(" class C color {0}", a.color);
			Console.WriteLine(" class C c.fE() {0}", c.fE);

			c = new F();
			Console.WriteLine(" class F c.Ff() {0}", c.cFf

		}
	}
}	
