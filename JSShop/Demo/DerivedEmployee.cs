using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSShop.Demo
{
    public  class DerivedEmployee:Employee
    {
        public int add()
        {
           
            return 1;
        }
        public override int Subtraction(int id)
        {
            base.Subtraction(id);
            return 1;
        }
    }
}
