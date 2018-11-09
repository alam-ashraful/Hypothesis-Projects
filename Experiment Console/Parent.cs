using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment_Console
{
    public class Parent
    {
        virtual protected void PrintParent(string value)
        {
            Console.WriteLine("Parent 1, {0}", value);
        }
    }
}
