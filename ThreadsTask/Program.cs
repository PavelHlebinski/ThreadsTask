using System.Threading;

namespace ThreadsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                Thread newThread = new Thread(new ParameterizedThreadStart(Worker.DoWork));
                newThread.Start(i + 1);
            }
        }
    }
}
