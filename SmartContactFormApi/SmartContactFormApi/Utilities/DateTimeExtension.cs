using SmartContactFormApi.Models;
using System;
using System.Collections.Generic;

namespace SmartContactFormApi.Utilities
{
    public class UkBankHolidays
    {

        private static List<DateTime> _holidays {get; set;}
        public static List<DateTime> Holidays { get{ 
             if (_holidays == null)
            {
                _holidays=new List<DateTime>();
                _holidays.Add(new DateTime(2015,8,31));
                _holidays.Add(new DateTime(2015,12,25));
                _holidays.Add(new DateTime(2015,12,28));

                //2016                
                _holidays.Add(new DateTime(2016,1,1));
                _holidays.Add(new DateTime(2016,3,25));
                _holidays.Add(new DateTime(2016,3,28));
                _holidays.Add(new DateTime(2016,5,2));
                _holidays.Add(new DateTime(2016,5,30));
                _holidays.Add(new DateTime(2016,8,29));
                _holidays.Add(new DateTime(2016,12,26));
                _holidays.Add(new DateTime(2016,12,27));

                //2017
                _holidays.Add(new DateTime(2017,1,1));
                _holidays.Add(new DateTime(2017,4,14));
                _holidays.Add(new DateTime(2017,4,17));
                _holidays.Add(new DateTime(2017,5,1));
                _holidays.Add(new DateTime(2017,5,29));
                _holidays.Add(new DateTime(2017,8,28));
                _holidays.Add(new DateTime(2017,12,25));
                _holidays.Add(new DateTime(2017,12,26));

                //2018
                _holidays.Add(new DateTime(2018,1,1));
                _holidays.Add(new DateTime(2018,3,30));
                _holidays.Add(new DateTime(2018,4,2));
                _holidays.Add(new DateTime(2018,5,7));
                _holidays.Add(new DateTime(2018,5,28));
                _holidays.Add(new DateTime(2018,8,27));
                _holidays.Add(new DateTime(2018,12,25));
                _holidays.Add(new DateTime(2018,12,26));
            }
            return _holidays;} }

       
    }

    public static class SubjectTypeExtension
    {
        public static bool IsCancelRequest(this SubjectType subjectType)
        {
            return subjectType == SubjectType.CancelAccount;
        }
    }

    public static class DateTimeExtension
    {

        public static bool IsUkHoliday(this DateTime dateTime)
        {
            return UkBankHolidays.Holidays.Contains(dateTime.Date);
        }



        
    }
}