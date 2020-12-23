using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN06
{
    public class Diem
    {
        protected double x;
        protected double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Diem()
        {
            x = 0;
            y = 0;
        }

        public Diem(double a, double b)
        {
            x = a;
            Y = b;
        }

        public double khoangCachDen(Diem A)
        {
            return Math.Sqrt((x - A.x) * (x - A.x) + (y - A.y) * (y - A.y));
        }

    }
}
