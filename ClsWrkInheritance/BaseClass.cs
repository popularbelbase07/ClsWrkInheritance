using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInheritance
{
    class BaseClass
    {
        public int _baseField1;
        private int _baseField2;
        protected int _baseField3;


        public BaseClass(int baseField1 , int baseField2)
        {
            _baseField1 = baseField1;
            _baseField2 = baseField2;
        }

        public void BaseMethod()
        {
            Console.WriteLine("Base Method");
        }

        // Step 1 : Method overriding
        // define virtual in method
        // i want to extend this method into derived class
        public virtual void Method()
        {
            Console.WriteLine("Base Virtual method");
        }
    }
}
