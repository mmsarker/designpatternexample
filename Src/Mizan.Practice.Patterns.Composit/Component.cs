using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Composite
{
    public abstract class Component
    {
        public Component Parent { get; set; }
        public int Level { get; set; }
        protected string Name { get; set; }
        public Component(string name)
        {
            this.Name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);

        public abstract void Display();
    }
}
