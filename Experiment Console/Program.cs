using System;

namespace Experiment_Console
{
    class Program : Child1
    {
        static void Main(string[] args)
        {
            new Program().PrintParent("Hello, world");
        }
    }
}
