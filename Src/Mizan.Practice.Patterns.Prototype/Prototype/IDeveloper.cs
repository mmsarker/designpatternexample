using System;

namespace Mizan.Practice.Patterns.Prototype
{
    public interface IDeveloper
    {
        string GetDetails();
        IDeveloper Clone();
    }
}
