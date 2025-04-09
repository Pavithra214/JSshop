using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSShop.CommonShop
{
    static class ExtensionMethod
    {

        public static int ToInt(this string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                return 0;
            }
            else
            {
                int.TryParse(str,out int x);
                return x;
            }
        }
    }
}
