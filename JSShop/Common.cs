using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JSShop
{
    public class Common
    {

        /// <summary>
        /// Converts string to int by ConvertInt menthod
        /// </summary>
        /// <param name="value">Provide string number value</param>
        /// <returns></returns>
        public int Convrtint(string value)
        {
            int result = 0;
            if(!string.IsNullOrWhiteSpace(value))
            {
                result=Convert.ToInt32(value);
            }
            return result;
        }

        public void Convrtintvalue(string value)
        {
            int result = 0;
            if (!string.IsNullOrWhiteSpace(value))
            {
                result = Convert.ToInt32(value);
            }
          
        }
        /// <summary>
        /// Calculating age by Year
        /// </summary>
        /// <param name="year">Provide the year value in string</param>
        /// <returns></returns>
        public int AgeCalc(string year)
        {
            int age = 0;
            int current = DateTime.Now.Year;
            if (!string.IsNullOrWhiteSpace(year))
            {
                int yearnum = Convert.ToInt32(year);
                age = current - yearnum;
               
            }
            return age;   
        }

        /// <summary>
        /// Calculating age by Year
        /// </summary>
        /// <param name="year">Provide the year value</param>
        /// <param name="day">Provide the day value in numbers</param>
        /// <returns></returns>
        public int AgeCalc(string year,int day)
        {
            int age = 0;
            int current = DateTime.Now.Year;
            if (!string.IsNullOrWhiteSpace(year))
            {
                int yearnum = Convert.ToInt32(year);
                age = current - yearnum;

            }
            day = DateTime.Now.Day;
            return age;
          
        }
        /// <summary>
        /// Calculating age by year
        /// </summary>
        /// <param name="year">Provide the year value in string</param>
        /// <param name="day">Provide the day value in nos.</param>
        /// <param name="month">Provide the month value in nos.</param>
        /// <returns></returns>
        public int AgeCalc(string year,int day,int month)
        {
            int age = 0;
            int current = DateTime.Now.Year;
            if (!string.IsNullOrWhiteSpace(year))
            {
                int yearnum = Convert.ToInt32(year);
                age = current - yearnum;

            }
            return age;
        }
        /// <summary>
        /// Calculating age by year
        /// </summary>
        /// <param name="year">Provide the year value in string</param>
        /// <param name="day">Provide the day value in string</param>
        /// <param name="month">Provide the month value in nos.</param>
        /// <returns></returns>

        public int AgeCalc(string year,string day,int month)
        {
            int age = 0;
            int current = DateTime.Now.Year;
            if (!string.IsNullOrWhiteSpace(year))
            {
                int yearnum = Convert.ToInt32(year);
                age = current - yearnum;

            }
            return age;
        }
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a">Provide the first number</param>
        /// <param name="b">Provide the second number</param>
        /// <returns></returns>
        public int AddNumber(int a,int b)
        {
            return a + b;
        }

        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a">Provide the first number</param>
        /// <param name="b">Provide the second number</param>
        /// <param name="c">Provide the third number</param>
        /// <returns></returns>
        public int AddNumber(int a, int b,int c)
        {
            return a + b+c;
        }

        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a">Provide the first number</param>
        /// <param name="b">Provide the second number</param>
        /// <param name="c">Provide the third number</param>
        /// <param name="d">Provide the fourth   number</param>
        /// <returns></returns>
        public int AddNumber(int a, int b,int c,int d)
        {
            return a + b+c+d;
        }

    }

    



    //public record struct NewStruct(string year, int day)
    //{
    //    public static implicit operator (int year, int day)(NewStruct value)
    //    {
    //        int age = 0;
    //        int current = DateTime.Now.Year;
    //        if (!string.IsNullOrWhiteSpace(value.year))
    //        {
    //            int yearnum = Convert.ToInt32(value.year);
    //            age = current - yearnum;

    //        }
    //        return (Convert.ToInt32(value.year), value.day);
    //    }

    //    public static implicit operator NewStruct((int age, int day) value)
    //    {
    //        return new NewStruct(value.age.ToString(), value.day);
    //    }
    //}
}
