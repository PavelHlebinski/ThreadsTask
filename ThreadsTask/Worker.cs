using System;
using System.Threading;

namespace ThreadsTask
{
    class Worker
    {
        private static Random _random = new Random();
        private static int _counter = 0;
        private static object _sync = new object();

        public static void DoWork(object msg)
        {
            lock (_sync)
            {
                Thread.Sleep(_random.Next(1, 4) * 300);
                for (var i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Message: {msg}; Counter: {_counter}; Inner iteration number: {i}");
                }
                _counter++;
            }
        }
    }
}
