using System;

namespace Mizan.Practice.Patterns.Composite
{
    public class CompositeClient
    {
        public void Test()
        {
            var root = new Composite("root");
            Composite c1 = new Composite("child1");
            root.Add(c1);

            Composite c11 = new Composite("child11");
            c1.Add(c11);
            Composite c111 = new Composite("child111");
            c11.Add(c111);
            Composite c12 = new Composite("child12");
            c1.Add(c12);            

            Composite c2 = new Composite("child1");
            Composite c3 = new Composite("child1");
            root.Add(c2);
            root.Add(c3);
            root.Display();
        }
    }
}
