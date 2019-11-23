using System;
namespace lab123
{
    class greeting
    {
        public string word;
        public greeting(){ word = "Hi";}
        public greeting(string word)
        {
            this.word = word;
        }
        static public void Write(greeting obj)
        {
            Console.WriteLine("{0}", obj.word);
        }
    }
    class program
    {
        static void Main()
        {
            greeting first = new greeting("Good Morning");
            greeting second = new greeting("Hello");
            greeting thirth = new greeting();
            greeting.Write(first);
            greeting.Write(second);
            greeting.Write(thirth);
        }
    }
}