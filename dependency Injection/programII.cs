using System;

namespace myNamespace
{
    public interface Iservice
    {
        void serve();
    }
    public class Service1 : Iservice
    {
        public void serve()
        {
            Console.WriteLine("Service 1 called!");
        }
    }
    public class Service2 : Iservice
    {
        public void serve()
        {
            Console.WriteLine("Service 2 called!");
        }

    }

    public class Client
    {
        private Iservice _service;
        public Client(Iservice service)
        {
            this._service = service;
        }
        public void serveMethod()
        {
            this._service.serve();

        }
    }
    public class MyClass
    {
        public static void Main(string[] args)
        {
            Service1 s1 = new Service1();
            Client c1 = new Client(s1);

            c1.serveMethod();
            Service2 s2 = new Service2();
            Client c2 = new Client(s2);
            c2.serveMethod();
        }
    }
}