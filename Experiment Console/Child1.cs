using System;
using System.Collections.Generic;
using System.Text;

namespace Experiment_Console
{
    public class Child1 : Parent
    {
        protected override void PrintParent(string value)
        {
            Console.WriteLine("{0} from {1}", value, this.GetType().BaseType.Name);
        }
    }
}
