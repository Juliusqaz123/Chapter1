using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
     static class Program
    {

        static void Main()
        {
            CreateAndRaise();
            Console.ReadLine();
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 1 called");

            p.OnChange += (sender, e)
                =>
            {
                throw new Exception();
            };

            p.OnChange += (sender, e)
                => Console.WriteLine("Subscriber 3 called");

            p.Raise();
        }
    }

    public class MyEventArgs : EventArgs
    {
        public MyEventArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class Pub
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
    }

    


}