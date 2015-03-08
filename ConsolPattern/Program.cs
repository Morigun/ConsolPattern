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
            /*Итак идея использования данного паттерна*/
            int x = 3, y = 4, z = 1;
            MyEventHandler myEv3 = () => FunkCalcTest(x, y, out z);
            MyEventHandler myEv4 = () => Console.WriteLine(String.Format("Z = {0}", z.ToString()));

            s.MyEvent += myEv3;
            s.MyEvent += myEv4;
            x = y * z;
            
            s.RaiseEvent(); //вызвать все делегаты
            z = x + y;
            x = z + 4;
            s.RaiseEvent(); //вызвать все делегаты
            Console.ReadKey();
        }

        public static void FunkCalcTest(int x, int y, out int z)
        {
            z = (x * y);
        }
    }
}
