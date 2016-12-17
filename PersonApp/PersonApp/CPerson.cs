using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    abstract   class CPerson
    {
        protected String Name;
        protected int Age;
        protected float Bonus;
        protected static int PersonCount; // Static variable PersonCount is used to calculate the total number of objects created.
        protected static float ClassMark;

        public CPerson(String n, int a)
        {
            Name = String.Copy(n);
            Age = a;
            PersonCount++;
        }
        public static int getCount()
        {
            return PersonCount;
        }
        public void setTotal(float s)
        {

            ClassMark += s;
        }
        public static float getClassMark()
        {
            return ClassMark/5;
        }

        public abstract float Calculate();
        
    }
}
