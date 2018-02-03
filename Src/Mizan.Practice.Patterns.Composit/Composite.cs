using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.Composite
{
    public class Composite : Component
    {
        private List<Component> _components;
        public Composite(string name) : base(name)
        {            
            this._components = new List<Component>();
        }

        public override void Add(Component c)
        {
            c.Parent = this;
            c.Level = this.Level + 1;
            this._components.Add(c);
        }

        public override void Display()
        {
            Console.WriteLine(new String('-', this.Level) + this.Name);

            foreach (var children in this._components)
            {
                children.Display();
            }
        }

        public override void Remove(Component c)
        {
            this._components.Remove(c);
        }
    }
}
