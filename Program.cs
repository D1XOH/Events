using System;

namespace EventRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassCounter Counter = new ClassCounter();
            Handler_I Handler1 = new Handler_I();
            Handler_II Handler2 = new Handler_II();
            Counter.onCount += Handler1.Message;
            Counter.onCount += Handler2.Message;

            Counter.Count();
        }
    }
}
