using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSShop.CommonShop
{
    public class ValidationShop
    {
        public int count=0;
        public static int countstatic;
        /// <summary>
        /// Password Validation
        /// </summary>
        /// <param name="password">Password should not b empty and should match</param>
        /// <param name="confirmpassword">Password should not b empty and should match</param>
        /// <returns></returns>
        public Boolean ComparePassword(string password, string confirmpassword)
        {
            Boolean result = false;
            if (String.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmpassword))
            {
                result = false;
            }
            else
            {
                if (password != confirmpassword)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Is Null or Whitespace validation for th fields
        /// </summary>
        /// <param name="name">Enter the string value</param>
        /// <returns></returns>

        public bool RequiredField(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Age validation
        /// </summary>
        /// <param name="age">Age cant be less than 0 and grater than 130</param>
        /// <returns></returns>
        public bool AgeRequirement(int age)
        {

                if (age < 0 || age > 130)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            
        }

        /// <summary>
        /// Email Validation
        /// </summary>
        /// <param name="emailval">Email should contain "@" and "." symbol</param>
        /// <returns></returns>
        public bool EmailValidation(string emailval,string emailchar1,string emailchar2)
        {
            if(emailval.Contains(emailchar1) && emailval.Contains(emailchar2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EmailValidation(string emailval, params string[] charsetemail)
        {
            bool result = false;
            foreach(var item in charsetemail)
            {
                if(emailval.Contains(item))
                {
                    result = true;
                }
                else
                {
                    return false;
                }
            }
            return result;
        }

        public bool PhoneValidation(string phone, params string[] charphone)
        {
            bool result = false;
            if (phone.Length != 10)
            {
                result = false;
            }
            else
            {
                foreach (var item in phone)
                {
                    if (phone.Contains(item))
                    {
                        result = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return result;
        }

           
    }
}
