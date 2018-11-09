using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment_Console
{
    public class Child1 : Parent
    {
        protected override void PrintParent(string value)
        {
            Console.WriteLine("Child 1, {0}", value);
        }
    }
}
