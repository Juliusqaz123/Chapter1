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
                => Console.WriteLine("Event raised: {0}", e.Value);

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

        private event EventHandler<MyEventArgs> onChange = delegate { };
        public event EventHandler<MyEventArgs> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }

        public void Raise()
        {
            onChange(this, new MyEventArgs(42));
        }
    }

    


}