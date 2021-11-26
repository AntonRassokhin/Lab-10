using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол в формате: градусы, минуты, секунды");
            Angle angle = new Angle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus, min, sec;
        bool f = false;

        public int Gradus 
        {
            set 
            {
                if (value > 0 && value < 361)
                {
                    gradus = value;

                }
                else
                {
                    Console.WriteLine("Ошибка! Введены градусы меньше 0 или больше 360.");
                    f = true;
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
                if (value > 0 && value < 61)
                {
                    min = value;

                }
                else
                {
                    Console.WriteLine("Ошибка! Введены минуты меньше 0 или больше 60.");
                    f = true;
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
                if (value > 0 && value < 61)
                {
                    sec = value;

                }
                else
                {
                    Console.WriteLine("Ошибка! Введены секунды меньше 0 или больше 60.");
                    f = true;
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public static Angle Input()
        {
            int gradus = Convert.ToInt32(Console.ReadLine());
            int min = Convert.ToInt32(Console.ReadLine());
            int sec = Convert.ToInt32(Console.ReadLine());
            return new Angle(gradus, min, sec);
        }                  
                
        public void ToRadians()
        {
            if (f == false)
            {
                double rad = ((double)Gradus) * 0.017453 + Min * 0.000291 + Sec * 0.000005;
                Console.WriteLine("Угол = {0:F5} радиан", rad);
            }
            else
            {
                Console.WriteLine("Гав! Считать не буду!");
            }
        }

    }
}
