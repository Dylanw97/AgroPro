using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace AgroPro
{
    class Data
    {
        public string Time(int state)
        {
            throw new NotImplementedException();
        }
        public string Date(int state)
        {
            DateTime date = DateTime.UtcNow.Date;

            if(state == 0)
            {
                date = DateTime.UtcNow.Date;
            }
            else if(state == 1)
            {

            }
            else if (state == 2)
            {

            }
            else if (state == 3)
            {

            }
            else if (state == 4)
            {

            }
            else if (state == 5)
            {

            }
            else if (state == 6)
            {

            }

            return date.ToString("dd/MM/yyyy");
        }

        public string DayOfWeek(int state)
        {
            var ShortWeekDay = "";

            var Date = DateTime.Today.AddDays(0);

            var Day = Date.ToString("dd");
            var Month = Date.ToString("MM");
            var Year = Date.ToString("yyyy");

            DateTime DayOfWeek;
            var DayOfWeekText = "";


            if (state == 0)
            {
                //DateTime dateValue = new DateTime(2008, 6, 11);
            }
            else if(state == 1)
            {
                Date = DateTime.Today.AddDays(1);

                Day = Date.ToString("d");
                Month = Date.ToString("MM");
                Year = Date.ToString("yyyy");

                DayOfWeek = new DateTime(Int32.Parse(Year), Int32.Parse(Day), Int32.Parse(Month));
                DayOfWeekText = DayOfWeek.ToString();   
            }
            else if(state == 2)
            {
                Date = DateTime.Today.AddDays(2);

                Day = Date.ToString("d");
                Month = Date.ToString("MM");
                Year = Date.ToString("yyyy");

                DayOfWeek = new DateTime(Int32.Parse(Year), Int32.Parse(Day), Int32.Parse(Month));
                DayOfWeekText = DayOfWeek.ToString();
            }
            else if (state == 3)
            {
                Date = DateTime.Today.AddDays(3);

                Day = Date.ToString("d");
                Month = Date.ToString("MM");
                Year = Date.ToString("yyyy");

                DayOfWeek = new DateTime(Int32.Parse(Year), Int32.Parse(Day), Int32.Parse(Month));
                DayOfWeekText = DayOfWeek.ToString();
            }
            else if (state == 4)
            {
                Date = DateTime.Today.AddDays(4);

                Day = Date.ToString("d");
                Month = Date.ToString("MM");
                Year = Date.ToString("yyyy");

                DayOfWeek = new DateTime(Int32.Parse(Year), Int32.Parse(Day), Int32.Parse(Month));
                DayOfWeekText = DayOfWeek.ToString();
            }
            else if (state == 5)
            {
                Date = DateTime.Today.AddDays(5);

                Day = Date.ToString("d");
                Month = Date.ToString("MM");
                Year = Date.ToString("yyyy");

                DayOfWeek = new DateTime(Int32.Parse(Year), Int32.Parse(Day), Int32.Parse(Month));
                DayOfWeekText = DayOfWeek.ToString();
            }
            else if (state == 6)
            {
                Date = DateTime.Today.AddDays(6);

                Day = Date.ToString("d");
                Month = Date.ToString("MM");
                Year = Date.ToString("yyyy");

                DayOfWeek = new DateTime(Int32.Parse(Year), Int32.Parse(Day), Int32.Parse(Month));
                DayOfWeekText = DayOfWeek.ToString();
            }

            /*
             * 
             */

            if (DayOfWeekText.Equals("monday"))
            {
                ShortWeekDay = "mon";
                return ShortWeekDay;
            }
            else if (DayOfWeekText.Equals("tuesday"))
            {
                ShortWeekDay = "tue";
                return ShortWeekDay;
            }
            else if (DayOfWeekText.Equals("wednesday"))
            {
                ShortWeekDay = "wed";
                return ShortWeekDay;
            }
            else if (DayOfWeekText.Equals("thursday"))
            {
                ShortWeekDay = "thur";
                return ShortWeekDay;
            }
            else if (DayOfWeekText.Equals("friday"))
            {
                ShortWeekDay = "fri";
                return ShortWeekDay;
            }
            else if (DayOfWeekText.Equals("saturday"))
            {
                ShortWeekDay = "sat";
                return ShortWeekDay;
            }
            else if (DayOfWeekText.Equals("sunday"))
            {
                ShortWeekDay = "sun";
                return ShortWeekDay;
            }

            return "";
        }
    }
}