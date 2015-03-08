using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolPattern
{
    
    class Program
    {
        public delegate void MyEventHandler(); // Пользовательский тип делегата

        public class Subject
        {
            public Subject() {}
        
            public MyEventHandler MyEvent; //Событие

            public void RaiseEvent()
            {
                MyEventHandler ev = MyEvent;
                if (ev != null)
                    ev();
            }
        }

        static void Main(string[] args)
        {
            Subject s = new Subject();
            MyEventHandler myEv1 = () => Console.WriteLine("Hello D");
            MyEventHandler myEv2 = () => Console.WriteLine("Hello World");
            s.MyEvent += myEv1;
            s.MyEvent += myEv2;
            s.MyEvent -= myEv1;
            s.RaiseEvent(); //вызвать все делегаты
            Console.ReadKey();
        }
    }
}
