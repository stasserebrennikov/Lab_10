using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    internal class Corner
    {
        int gradus;
        int minute;
        int sec;
        public bool isCorrect = true;

        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0 || value > 359)
                    isCorrect = false;
                else
                    gradus = value;
            }

        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Gradus += value / 60;
                    minute = value % 60;
                }
            }
        }
        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Minute += value / 60;
                    sec = value % 60;
                }
            }
        }
        public Corner(int gradus, int minute, int second)
        {
            this.Gradus = gradus;
            this.Minute = minute;
            this.Sec = second;
        }
        public double ToRadians()
        {
            return gradus * Math.PI / 180;
        }
    }
}
