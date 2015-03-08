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
            s.MyEvent += () => Console.WriteLine("Hello D"); // присоеденить делегат
            s.MyEvent += () => Console.WriteLine("Hello World"); // присоеденить делегат
            s.RaiseEvent(); //вызвать все делегаты
            Console.ReadKey();
        }
    }
}
