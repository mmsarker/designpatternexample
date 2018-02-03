using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component c)
        {
        }

        public override void Display()
        {
            Console.WriteLine(new String('-', this.Level) + this.Name);
        }

        public override void Remove(Component c)
        {
        }
    }
}
