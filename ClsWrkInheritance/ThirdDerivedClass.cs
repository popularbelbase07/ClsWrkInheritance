using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInheritance
{
    class ThirdDerivedClass : BaseClass
    {
        public ThirdDerivedClass(int baseField1, int baseField2) : base(baseField1, baseField2)
        {
        }

        public void ThirdDerivedMethod()
        {
            Console.WriteLine("Third Derived Method");
        }
        public override void Method()
        {
            Console.WriteLine("Third Derived Method");
        }
    }
}
