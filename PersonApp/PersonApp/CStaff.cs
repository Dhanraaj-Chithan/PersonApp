using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class CStaff : CPerson
    {
        private int Nopp;      
        private int Staffid;
        private int Staffexp;
        public CStaff(String name,int age,int exp,int pp,int sid) : base(name,age)
        {
            Nopp = pp;
            Staffid = sid;
            Staffexp = exp;
        }
        public override float Calculate()
        {
            Bonus = Staffexp*Nopp;
            return Bonus;
        }
        public static float operator +(CStaff S1, CStaff S2)
        {
            float a = S1.Nopp + S2.Nopp;
            return a;
        }

    }
}
