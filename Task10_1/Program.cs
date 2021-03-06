using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle angle = new Angle(298, 54, 32);
            Console.WriteLine("Угол [ГМС]: {0}°{1}'{2}\"", angle.Gradus,angle.Min,angle.Sec);
            Console.Write("Угол [радианы]: ");
            angle.ToRadians(angle.Gradus, angle.Min, angle.Sec);
            Console.ReadKey();
        }
    }

    class Angle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    gradus = value;
                }
                else
                {
                    if (value >= 360)
                    {
                        Console.WriteLine("Градусы должны быть в диапазоне 0-359");
                        //gradus = value % 360; //для приведения значений минут к диапазону 0-359
                    }
                    else
                    {
                        Console.WriteLine("Градусы не могут быть отрицательными");
                    }
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    if (value >= 60)
                    {
                        Console.WriteLine("Минуты должны быть в диапазоне 0-59");
                        //min = value % 60; //для приведения значений минут к диапазону 0-59
                    }
                    else
                    {
                        Console.WriteLine("Минуты не могут быть отрицательными");
                    }
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    if (value >= 60)
                    {
                        Console.WriteLine("Секунды должны быть в диапазоне 0-59");
                        //sec = value % 60; //для приведения значений секунд к диапазону 0-59
                    }
                    else
                    {
                        Console.WriteLine("Секунды не могут быть отрицательными");
                    }
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus = 0, int min = 0, int sec = 0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians(int gradus, int min, int sec)
        {
            double radians = (gradus + (min + (float)sec / 60) / 60) * Math.PI/180;
            Console.WriteLine("{0:f5} рад",radians);
        }
    }
}
