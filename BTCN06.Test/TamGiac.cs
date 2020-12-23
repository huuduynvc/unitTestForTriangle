using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BTCN06.Test
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

        public TamGiac(Diem x,Diem y,Diem z)
        {
            a = x; b = y; c = z;
        }

        public double chuVi()
        {
            if(loaiTamGiac() != 0)
            {
                return (a.khoangCachDen(b) + b.khoangCachDen(c) + c.khoangCachDen(a));
            }
            return 0;
        }

        // Loai tam giac
        // 0: Khong phai tam giac
        // 1: Tam giac thuong
        // 2: Tam giac deu
        // 3: Tam giac can
        // 4: Tam giac vuong
        // 5: Tam giac vuong can
        public int loaiTamGiac()
        {
            double epsilon = 0.000001;

            double AB = a.khoangCachDen(b);
            double BC = b.khoangCachDen(c);
            double CA = c.khoangCachDen(a);

            if(AB + BC <= CA || AB + CA <= BC || BC + CA <= AB)
            {
                return 0;
            }
            else if(Math.Abs(AB - BC) <= epsilon && Math.Abs(BC - CA) <= epsilon)
            {
                return 2;         
            }
            else if(Math.Abs(AB - BC) <= epsilon || Math.Abs(BC - CA) <= epsilon || Math.Abs(CA - AB) <= epsilon)
            {
                if (Math.Abs(AB * AB + BC * BC - CA * CA) <= epsilon || Math.Abs(AB * AB + CA * CA - BC * BC) <= epsilon || Math.Abs(CA * CA + BC * BC - AB * AB) <= epsilon)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
            else if(Math.Abs(AB * AB + BC * BC - CA * CA) <= epsilon || Math.Abs(AB * AB + CA * CA - BC * BC) <= epsilon || Math.Abs(CA * CA + BC * BC - AB * AB) <= epsilon)
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
