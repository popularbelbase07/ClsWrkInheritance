using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInheritance
{
    class SecondDerivedClass : DerivedClass
    {
        private int _secondDerivedField1;

        public SecondDerivedClass(int baseField1, int baseField2, int derivedField1, int secondDerivedField1) : base(baseField1, baseField2, derivedField1)
        {
            _secondDerivedField1 = secondDerivedField1;
        }

        public void SecondDerivedMethod()
        {
            Console.WriteLine("Second drive Method");
            
        }
    }
}
