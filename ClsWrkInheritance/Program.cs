using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
             DerivedClass derivedClass = new DerivedClass(1,2,3);
             // derived class object easily access the Base class members              
             derivedClass.BaseMethod();
            // As natural derive class object call their own method
             derivedClass.DerivedMethod();

            SecondDerivedClass secondDerived = new SecondDerivedClass(23, 45, 56, 78);

            //BaseClass baseClass = new BaseClass(23, 45);
            //baseClass.Method();

            //DerivedClass derivedClass = new DerivedClass(23, 45, 67);
            //derivedClass.Method();

            //ThirdDerivedClass thirdDerivedClass = new ThirdDerivedClass(23, 45);
            //thirdDerivedClass.Method();

            //BaseClass baseClasObjRefrence = new DerivedClass(23, 45, 67);
            //baseClasObjRefrence.Method();

            BaseClass baseClasObjRefrence1 = new ThirdDerivedClass(23, 45);
            baseClasObjRefrence1.Method();

            ThirdDerivedClass obj = new ThirdDerivedClass(23, 45);
            obj.Method();

            Console.ReadKey();

        }
    }
}
