using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign7
{
    internal class Duration
    {
        private int hours, minutes, seconds;
        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public Duration() {}
        public Duration(int sec)
        {
            seconds = sec;
            while (seconds >= 3600)
            {
                hours++;
                seconds-=3600;
            }
            while (seconds >= 60)
            {
                minutes++;
                seconds-=60;
            }
            while(minutes >= 60)
            {
                hours++;
                minutes-=60;
            }
        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            Duration temp = new Duration();
            temp.hours = d1.hours + d2.hours;
            temp.seconds = d1.seconds + d2.seconds;
            temp.minutes = d1.minutes + d2.minutes;
            while(temp.seconds >= 60)
            {
                temp.minutes++;
                temp.seconds -= 60;
            }
            while (temp.minutes >= 60)
            {
                temp.hours++;
                temp.minutes -= 60;
            }
        return temp;
        }
        public static Duration operator +(int seconds, Duration d)
        {
            
            return new Duration(d.seconds + seconds);
        }
        public static Duration operator +(Duration d,int seconds)
        {
            
            return new Duration(d.seconds + seconds);
        }
        public static Duration operator -(int seconds, Duration d)
        {
            
            return new Duration(Math.Abs(d.seconds - seconds));
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            Duration temp = new Duration();
            temp.hours = Math.Abs(d1.hours - d2.hours);
            temp.seconds = Math.Abs(d1.seconds - d2.seconds);
            temp.minutes = Math.Abs(d1.minutes - d2.minutes);
            while (temp.seconds >= 60)
            {
                temp.minutes++;
                temp.seconds -= 60;
            }
            while (temp.minutes >= 60)
            {
                temp.hours++;
                temp.minutes -= 60;
            }
            return temp;
        }
        public static Duration operator ++(Duration d1)
        {
            d1.minutes++;
            while(d1.minutes >= 60)
            {
                d1.hours++;
                d1.minutes-=60;
            }
            return d1;
        }
        public static Duration operator --(Duration d1)
        {
            d1.minutes--;
            
            return d1;
        }
        public static bool operator >(Duration d1,Duration d2)
        {
            if (d1.hours > d2.hours) return true;
            if(d1.minutes > d2.minutes) return true;
            if(d1.seconds > d2.seconds) return true;
            return false;
        }
        public static bool operator <(Duration d1,Duration d2)
        {
            if (d1.hours < d2.hours) return true;
            if(d1.minutes < d2.minutes) return true;
            if(d1.seconds < d2.seconds) return true;
            return false;
        }
        public static bool operator <=(Duration d1,Duration d2)
        {
            if (d1.hours <= d2.hours) return true;
            if(d1.minutes <= d2.minutes) return true;
            if(d1.seconds <= d2.seconds) return true;
            return false;
        }
        public static bool operator >=(Duration d1,Duration d2)
        {
            if (d1.hours >= d2.hours) return true;
            if(d1.minutes >= d2.minutes) return true;
            if(d1.seconds >= d2.seconds) return true;
            return false;
        }
        public static bool operator true(Duration d)
        {
            return d.hours > 0 || d.minutes>0 || d.seconds>0;
            
        }
        public static bool operator false(Duration d)
        {
            return d.hours == 0 && d.minutes==0 && d.seconds==0;
            
        }
        public override string ToString()
        {
            return $"hours: {hours}, minutes: {minutes}, seconds: {seconds}";
        }
    }
}
