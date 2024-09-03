namespace Laba4zad1._1
{
    internal class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int hours, int minutes, int seconds)
        {
            set_hours(hours);

            set_minutes(minutes);

            set_seconds(seconds);

        }

        public override string ToString()
        {
            return string.Format("{0,2}:{1,2}:{2,2}", hours, minutes, seconds);
        }

        public void set_hours(int hours)
        {
            if (hours < 0 || hours > 23)
            {
                throw new ArgumentException("bad hours range");
            }
            this.hours = hours;
        }

        public void set_minutes(int minutes)
        {
            if (minutes < 0 || minutes > 60)
            {
                throw new ArgumentException("bad minutes range");
            }
            this.minutes = minutes;
        }

        public void set_seconds(int seconds)
        {
            if (seconds < 0 || seconds > 60)
            {
                throw new ArgumentException("bad seconds range");
            }
            this.seconds = seconds;
        }




        public void add_time(int hours, int minutes, int seconds)
        {
            if (hours < -36 || minutes < -60 || seconds < -60)
            {
                throw new ArgumentException("bad time range");
            }
            else
            {
                if (this.seconds + seconds > 59)
                {
                    this.minutes += (this.seconds + seconds) / 60;
                    this.seconds = (this.seconds + seconds) % 60;
                }
                else if (this.seconds + seconds < 0)
                {
                    this.minutes -= ((this.seconds + seconds) / 60) + 1;
                    this.seconds = 60 + (this.seconds + seconds);
                }
                else
                {
                    this.seconds += seconds;
                }


                if (this.minutes + minutes > 59)
                {
                    this.hours += (this.minutes + minutes) / 60;
                    this.minutes = (this.minutes + minutes) % 60;
                }
                else if (this.minutes + minutes < 0)
                {
                    this.hours -= ((this.minutes + minutes) / 60) + 1;
                    this.minutes = 60 + (this.minutes + minutes);
                }
                else
                {
                    this.minutes += minutes;
                }


                if (this.hours + hours > 23)
                {
                    this.hours = (this.hours + hours) % 24;
                }
                else if (this.hours + hours < 0)
                {
                    this.hours = 24 + (this.hours + hours);
                }
                else
                {
                    this.hours += hours;
                }
            }
        }
    }
}
