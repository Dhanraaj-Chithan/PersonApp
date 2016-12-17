using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class CStudent  : CPerson , IStudent
    {
        private int Mark1;
        private int Mark2;
        private int Rollno;

        
        public CStudent(String name,int age,int m1,int m2,int r) : base(name,age)
        {
            Mark1 = m1;
            Mark2 = m2;
            Rollno = r;
     
        }

        public override float Calculate()
        {
            return  (Mark1 + Mark2) / 2;
        }


        public static float operator+ (CStudent S1, CStudent S2)
        {
            float a = S1.Calculate() + S2.Calculate();
            return a;
        }


    }
}
