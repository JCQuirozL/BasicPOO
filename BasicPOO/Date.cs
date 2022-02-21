using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPOO
{
    internal class Date
    {
        public int _year;
        public int _month;
        public int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = IsValidMonth(month); 
            _day = IsValidDay(day);
        }

        private int IsValidDay(int day)
        {
            if (day <= 31)
            {
                if (_month == 2 && day == 29 && !IsLeapYear(_year))
                {
                    throw new DayException("Sorry, invalid day.");
                }

            }

            return day;
           
           
        }

        private bool IsLeapYear(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
            
        }

        private int IsValidMonth(int month)
        {
            if (month == 0 || month > 12)
            {
                throw new MonthException("Sorry, Invalid Month.");
            }
            return month;
        }

        public override string ToString()
        {
            return $"{_year}/{_month}/{_day}";
        }
    }
    
}



