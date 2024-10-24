using System;
using System.Collections.Generic;

namespace injection
{
    public interface Itext
    {
        void print();
    }
    class Format : Itext
    {
        public void print()
        {
            Console.WriteLine("Welcome to Jannah!");
        }
    }
    //Constructor Injection
    public class ConstructorInjection
    {
        private Itext _text;
        public ConstructorInjection(Itext t1)
        {
            this._text = t1;
        }
        public void print()
        {
            _text.print();
        }

    }
    class Constructor
    {
        public static void Main(string[] args)
        {
            ConstructorInjection cs = new ConstructorInjection(new Format());
            cs.print();
            Console.ReadKey();
        }
    }
}