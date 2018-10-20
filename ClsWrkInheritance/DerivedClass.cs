using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInheritance
{
    class DerivedClass : BaseClass
    {
        public int _derivedField1;


        public DerivedClass(int baseField1, int baseField2, int derivedField1) : base(baseField1, baseField2)
        {
            _derivedField1 = derivedField1;
        }

        public void DerivedMethod()
        {
            
            Console.WriteLine("Derived Method");
            // I can access this field directly in the derived 
            int protect = _baseField3;
        }

        public override void Method()
        {
            Console.WriteLine("Derived Method");
        }
    }
}
