using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCN06
{
    public class TamGiac : Diem
    {
        protected Diem a;
        protected Diem b;
        protected Diem c;

        public Diem A { get => a; set => a = value; }
        public Diem B { get => b; set => b = value; }
        public Diem C { get => c; set => c = value; }

        public TamGiac()
        {
            a = b = c = new Diem();
        }

        public TamGiac(Diem x, Diem y, Diem z)
        {
            a = x; b = y; c = z;
        }

        public double chuVi()
        {
            return (a.khoangCachDen(b) + b.khoangCachDen(c) + c.khoangCachDen(a));
        }

        public int loaiTamGiac()
        {
            // Loai tam giac
            // 0: Khong phai tam giac
            // 1: Tam giac thuong
            // 2: Tam giac deu
            // 3: Tam giac can
            // 4: Tam giac vuong
            // 5: Tam giac vuong can

            double AB = a.khoangCachDen(b);
            double BC = b.khoangCachDen(c);
            double CA = c.khoangCachDen(a);

            if (AB + BC < CA || AB + CA < BC || BC + CA < AB)
            {
                return 0;
            }
            else if (AB == BC && BC == CA)
            {
                return 2;
            }
            else if (AB == BC || BC == CA || CA == AB)
            {
                if (AB * AB + BC * BC == CA * CA || AB * AB + CA * CA == BC * BC || CA * CA + BC * BC == AB * AB)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
            else if (AB * AB + BC * BC == CA * CA || AB * AB + CA * CA == BC * BC || CA * CA + BC * BC == AB * AB)
            {
                return 4;
            }
            else
            {
                return 1;
            }
        }
    }
}
