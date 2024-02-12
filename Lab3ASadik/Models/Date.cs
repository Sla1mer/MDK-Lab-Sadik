using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3ASadik.Models
{
    public class Date
    {
        public uint Year {  get; set; }
        public uint Month { get; set; }
        public uint Day { get; set; }

        public Date(uint year, uint month, uint day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(string dateString)
        {
            string[] parts = dateString.Split('.');
            if (parts.Length != 3)
                throw new ArgumentException("Invalid date string format. Use 'yyyy.mm.dd'");

            Year = uint.Parse(parts[0]);
            Month = uint.Parse(parts[1]);
            Day = uint.Parse(parts[2]);
        }

        public Date(DateOnly dateTime)
        {
            Year = (uint)dateTime.Year;
            Month = (uint)dateTime.Month;
            Day = (uint)dateTime.Day;
        }

        public static Date operator +(Date date, int days)
        {
            DateTime dateTime = new DateTime((int)date.Year, (int)date.Month, (int)date.Day);
            dateTime = dateTime.AddDays(days);
            return new Date((uint)dateTime.Year, (uint)dateTime.Month, (uint)dateTime.Day);
        }

        public static Date operator -(Date date, int days)
        {
            return date + (-days);
        }

        public bool IsLeapYear()
        {
            return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
        }

        public static int DaysBetween(Date date1, Date date2)
        {
            DateTime dateTime1 = new DateTime((int)date1.Year, (int)date1.Month, (int)date1.Day);
            DateTime dateTime2 = new DateTime((int)date2.Year, (int)date2.Month, (int)date2.Day);

            TimeSpan span = dateTime2 - dateTime1;
            return span.Days;
        }

        public static Date Today()
        {
            DateTime today = DateTime.Today;
            return new Date((uint)today.Year, (uint)today.Month, (uint)today.Day);
        }

        public static bool operator ==(Date date1, Date date2)
        {
            return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
        }

        public static bool operator !=(Date date1, Date date2)
        {
            return !(date1 == date2);
        }

        public static bool operator >(Date date1, Date date2)
        {
            if (date1.Year > date2.Year)
                return true;
            else if (date1.Year < date2.Year)
                return false;
            else if (date1.Month > date2.Month)
                return true;
            else if (date1.Month < date2.Month)
                return false;
            else
                return date1.Day > date2.Day;
        }

        public static bool operator <(Date date1, Date date2)
        {
            if (date1 == date2)
                return false;
            else
                return !(date1 > date2);
        }

        public uint GetYear()
        {
            return Year;
        }

        public uint GetMonth()
        {
            return Month;
        }

        public uint GetDay()
        {
            return Day;
        }
    }
}
