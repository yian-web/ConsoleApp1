using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class OOP
    {
        public void main()
        {
            //ElectricCar.main(); // Q1
            //Derived1 b = new DeriDerived1(); //Q2
            //Four.main();//03
            //InfiniteMath.main();//04
            //TestParent.main();//05
            //Console.WriteLine(new delegateTest1().func3(1, 2, 4, 8));//06

            //Console.WriteLine(new Class2().getValue());//07
            //  Console.WriteLine(new Class2().funtion1());
            //Console.WriteLine(Class2.Value);
            //new Q08B().PrintFields();//08
            //Q09B.MainQ09B();//09

            //MDelegate m1 = new MDelegate(DM.Display);//10
            //MDelegate m2 = new MDelegate(DM.print);
            //MDelegate m3 = m1 + m2;
            //MDelegate m4 = m2 + m1;
            //MDelegate m5 = m3 - m2;
            //m3();
            //m4();
            //m5();

            //var speaker = new Speaker { Name = "Gaurav Kumar Arora" };//11
            //var isTrue = speaker is Speaker;
            //Console.WriteLine("speaker is of Speaker type:{0}", isTrue);

            //var author = new Author { Name = "Gaurav Kumar Arora" };
            //isTrue = speaker is Author;
            //Console.WriteLine("speaker is of Author type:{0}", isTrue);

            //var authorName = GetAuthorName(author);
            //Console.WriteLine("Author name is:{0}", authorName);
            //authorName = GetAuthorName(speaker);
            //Console.WriteLine("Author name is:{0}", authorName);

            //var anonymousData = new // 12
            //
            //    ForeName = "Fore",
            //    SurName = "Sur"
            //};
            //Console.WriteLine("First Name : " + anonymousData.ForeName);
        }
        public static string GetAuthorName(dynamic obj)
        {
            Author authorObj = obj as Author;
            return (authorObj != null) ? authorObj.Name : string.Empty;
        }
    }

    public class Automobile
    {
        public String drive()
        {
            return "Driving vehicle";
        }
    }

    public class Car : Automobile
    {
        public static int aa = 5;
        public readonly int wheels = 2;
        public virtual String drive()
        {
            return "Driving car";
        }
    }

    public class ElectricCar : Car
    {
        public readonly int wheels = 4;
        public sealed override String drive()
        {
            return "Driving an electric car";
        }

        public static void main()
        {
            Car car = new ElectricCar();
            Console.WriteLine(car.drive());
            Console.WriteLine(car.wheels);
        }
    }

    class Base1
    {
        public Base1()
        {
            Console.WriteLine("Base");
        }
    }

    class Derived1 : Base1
    {
        public Derived1()
        {
            Console.WriteLine("Derived");
        }
    }

    class DeriDerived1 : Derived1
    {
        public DeriDerived1()
        {
            Console.WriteLine("DeriDerived");
        }
    }

    class One
    {
        public One()
        {
            Console.WriteLine("One");
        }
    }
    class Two : One
    {
        public Two()
        {
            Console.WriteLine("Two");
        }
    }
    class Three : Two
    {
        public Three()
        {
            Console.WriteLine("Three");
        }
    }
    public class Four
    {
        public static void main()
        {
            Three three = new Three();
        }
    }

    class Math
    {
        public readonly double secret = 2;
    }

    class ComplexMath : Math
    {
        public readonly double secret = 4;
    }

    class InfiniteMath : ComplexMath
    {
        public readonly double secret = 8;
        public static void main()
        {
            Math math = new InfiniteMath();
            Console.WriteLine(math.secret);

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

    public class TestParent
    {
        public static void main()
        {
            Parent parent = new Child();
            parent.className();
        }
    }

    public class delegateTest1
    {
        public Func<int, int, int, int, int> func3 = (x, y, a, b) => { return x + y + a + b; };
    }



    public class Class2 : abClass1, inter1
    {
        public static int Value = 2;
        public override int getValue()
        {
            return 2;
        }

        public int funtion1()
        {
            return base.getValue();
        }
    }
    interface inter1
    {
        int funtion1();
    }

    public abstract class abClass1 : abClass0
    {
        public static int Value = 1;
        public override int getValue()
        {
            return 1;
        }
        public int funtion1()
        {
            return getValue();
        }
    }

    public abstract class abClass0
    {
        public abstract int getValue();
        public static int Value = 0;
    }


    class Q08A
    {
        public Q08A()
        {
            PrintFields();
        }
        public virtual void PrintFields() { }
    }
    class Q08B : Q08A
    {
        int x = 1;
        int y;
        public Q08B()
        {
            y = -1;
        }
        public override void PrintFields()
        {
            Console.WriteLine("x={0},y={1}", x, y);
        }
    }

    class Qo9A
    {
        public static int X;
        static Qo9A()
        {
            X = Q09B.Y + 1;
        }
    }
    class Q09B
    {
        public static int Y = Qo9A.X + 1;
        static Q09B() { }
        public static void MainQ09B()
        {
            Console.WriteLine("X={0},Y={1}", Qo9A.X, Q09B.Y);
        }
    }

    delegate void MDelegate();
    class DM
    {
        static public void Display()
        {
            Console.WriteLine("Display");
        }
        static public void print()
        {
            Console.WriteLine("print");
        }
    }

    class Speaker
    {
        public string Name
        {
            get;
            set;
        }
    }
    class Author
    {
        public string Name
        {
            get;
            set;
        }
    }
}