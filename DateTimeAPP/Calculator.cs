using System;
using System.Globalization;

namespace DateTimeAPP
{
    internal class Calculator
    {
        internal static string getTomorrow(DateTime date)
        {
           return date.AddDays(1).ToString(new CultureInfo("en-us"));
            //throw new NotImplementedException();
        }

        internal static string getYesterday(DateTime date)
        {
            return date.AddDays(-1).ToString(new CultureInfo("en-us"));
            //throw new NotImplementedException();
        }

        internal static string getDayAfetrTomorrow(DateTime date)
        {
            return date.AddDays(2).ToString(new CultureInfo("en-us"));
        }

        internal static string getDayBeforeYesterday(DateTime date)
        {
            return date.AddDays(-2).ToString(new CultureInfo("en-us"));
        }

        internal static string addDays(DateTime date1, int number)
        {
            //throw new NotImplementedException();
            return date1.AddDays(number).ToString(new CultureInfo("en-us"));
        }

        internal static string addYears(DateTime date1, int number2)
        {
            return date1.AddYears(number2).ToString(new CultureInfo("en-us"));
        }

        internal static string addMonths(DateTime date1, int number1)
        {
            return date1.AddMonths(number1).ToString(new CultureInfo("en-us"));
            //throw new NotImplementedException();
        }

        internal static string subYears(DateTime date1, int number3)
        {
            //throw new NotImplementedException();
            return date1.AddYears(-number3).ToString(new CultureInfo("en-us"));

        }

        internal static string subMonths(DateTime date1, int number4)
        {
            return date1.AddMonths(-number4).ToString(new CultureInfo("en-us"));
        }

        internal static string subDays(DateTime date1, int number5)
        {
            return date1.AddDays(-number5).ToString(new CultureInfo("en-us"));
        }

        internal static string calculateDifference(DateTime date1, DateTime date2)
        {
            //throw new NotImplementedException();
            //return (date1 - date2).ToString();
            if (date1.CompareTo(date2) > 0)
            {
                return (date1 - date2).ToString();
            }
            else return (date2 - date1).ToString();
        }

        internal static string dayOfYear(DateTime date1)
        {
            //throw new NotImplementedException();
            // var diff = Math.Abs(date1);
            return date1.DayOfYear.ToString();

        }
    }
}