using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSShop.Demo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Addition(int id)
        {
            return 1;
        }
        public virtual int Subtraction(int id)
        {
            return 1;
        }
    }
}
