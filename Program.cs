using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //new delegateTest();

            // function Delegate 
            //var myDelegateTest = new delegateTest();
            //Console.WriteLine(myDelegateTest.func3(1, 2, 3, 4));

            // set target method
            //MyDelegate del = new MyDelegate(MethodA);
            // del = MethodA;
            //// or set lambda expression 
            MyDelegate del = (string msg) => Console.WriteLine(msg);
            del("hello world");

            //AlarmClock clock = new AlarmClock();
            //// 訂閱事件，指定處理程序
            //clock.Alarm += (sender, e) =>
            //{
            //    Console.WriteLine("時間到了，該起床了！");
            //};
            //// 模擬鬧鐘觸發
            //clock.TriggerAlarm();
            //
            //Derived b = new DeriDerived();

            //Car car = new ElectricCar();
            //Console.WriteLine(car.drive());

            //One one = new Two();
            //one.print();

            //Parent parent = new Child();
            //parent.className();

            // int aaI = Int32("5")

            //Inface inface = new Inface(5);
            //Console.WriteLine(inface.geta());

            //new SomeY(20).doYourWork();

            //new Seal().func();
            //new OOP().main();


            //new ThreadExm().doFun();
            Console.ReadKey();
        }

        class AlarmClock
        {
            // 定義事件
            public event EventHandler Alarm;
            // 模擬鬧鐘觸發事件
            public void TriggerAlarm()
            {
                Console.WriteLine("鬧鐘響了！");
                OnAlarm(); // 觸發事件
            }
            // 處理事件的方法
            protected virtual void OnAlarm()
            {
                Alarm?.Invoke(this, EventArgs.Empty);
            }
        }

        void enumerable()
        {
            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };

            IEnumerable<int> query = numbers.Where((number, index) => number <= index * 10);

            foreach (int number in query)
            {
                Console.WriteLine(number);
            }
        }
        void ActionTDelegate()
        {
            List<string> names = new List<string>();
            names.Add("Bruce");
            names.Add("Alfred");
            names.Add("Tim");
            names.Add("Richard");

            // Display the contents of the list using the Print method.
            //names.ForEach(Print);

            // The following demonstrates the anonymous method feature of C#
            // to display the contents of the list to the console.

            names.ForEach(delegate (string name)
            {
                Console.WriteLine(name);
            });
        }

        public class delegateTest
        {
            //Callback handler = DelegateMethod;
            //handler(1, 2, 3, 4);

            //Func<string> func = () => "Hello World";

            //Func<int, int> func1 = x => x + 1;

            //Func<string, string, bool> func2 = (x, y) => x.StartsWith(y);

            public Func<int, int, int, int, int> func3 = (x, y, a, b) => { return x + y + a + b; };


            //public Action func = ()=> Console.WriteLine("");

            //public Action<int> func2 = (x) => Console.WriteLine(x);

            //public Action<in T1, in T2>(T1 arg1, T2 arg2);
        }

        public delegate void Callback(int x, int y, int a, int b);
        public void DelegateMethod(int x, int y, int a, int b)
        {
            Console.WriteLine(x + y + a + b);
        }

        public delegate TResult Func<out TResult>();

        public delegate TResult Func<in T, out TResult>(T arg);

        public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

        static int fun1(int a, int b)
        {
            return a + b;
        }
        static int fun2(int a, int b)
        {
            return a - b;
        }

        public delegate void MyDelegate(string msg); // declare a delegate

        //static void MethodA(string message)
        //{
        //    Console.WriteLine(message);
        //}
    }


    class Base
    {
        public Base()
        {
            Console.WriteLine("Base");
        }
    }
    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived");
        }
    }

    class DeriDerived : Derived
    {
        public DeriDerived()
        {
            Console.WriteLine("DeriDerived");
        }
    }


    class One
    {
        public void print()
        {
            Console.WriteLine("1");
        }
    }

    class Two : One
    {

        public void print()
        {
            Console.WriteLine("2");
        }
    }

    class Parent
    {
        public void className()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent
    {
        void className()
        {
            Console.WriteLine("Child");
        }
    }

    public class Car
    {
        public String drive()
        {
            return "Driving car";
        }
    }

    public class ElectricCar : Car
    {
        public String drive()
        {
            return "Driving an electric car";
        }
    }

    public class Inface : someI, someII
    {
        public Inface(int value) : base()
        {
            doYourValue2 = value;
        }
        public override void doYourWork()
        {

        }
        public void doYourWork3()
        {
            //doYourValu3++;
        }
        //a= doYourValue3;
        //int b {
        //    get { base.doYourValue}
        //    set;
        //}
    }
    interface someII
    {
        void doYourWork3();
    }

    public abstract class someI : some0
    {
        //public abstract void doYourWork();

        //public static int doYourValue = 3;
        //public  int doYourValue2 = 3;
        public someI()
        {
            //doYourValue2 = 2;
        }
    }

    public abstract class some0
    {
        public abstract void doYourWork();

        public static int doYourValue = 3;
        public int doYourValue2 = 3;
    }


    public abstract class SomeX
    {
        public abstract void doYourWork();

        public void doYourWor2()
        {
            Console.WriteLine("doYourValue2 = " + doYourValue2);
            Console.WriteLine("doYourValue = " + doYourValue);
        }

        public int doYourValue2;
        public static int doYourValue = 3;
    }

    public class SomeY : SomeX
    {
        public SomeY(int value) : base()
        {
            doYourValue2 = value;
        }
        public override void doYourWork()
        {
            base.doYourWor2();
        }
    }



    public sealed class Seal
    {
        public void func()
        {
            try
            {
                int ii = Convert.ToInt32("123");
                String str = Convert.ToString(123);
                char ch = str.ToCharArray()[0];

                for (int x = 1; x < 10; x++)
                {
                    for (int y = 1; y < 10; y++)
                    {
                        Console.Write(x + " * " + y + " = " + x * y + " ", 10);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    public class ThreadExm
    {
        private void FirstThreadFun()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "   i =  " + i);

            }
            Console.WriteLine(Thread.CurrentThread.Name + " Done");
        }

        public void doFun()
        {
            Thread.CurrentThread.Name = "MainThread";
            Thread testThread = new Thread(new ThreadStart(new ThreadExm().FirstThreadFun));
            testThread.Name = "firstThread";

            for (int z = 0; z < 20; z++)
            {
                if (z == 10)
                {
                    testThread.Start();
                    testThread.Join();
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "   z =  " + z);
                }
            }
        }
    }




}

