using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics;

namespace BTCN06.Test
{
    [TestFixture]
    public class TamGiacTest
    {
        TamGiac t;

        [SetUp]
        public void Setup()
        {
            t = new TamGiac();
        }

        [Test]
        public void LaTamGiacVuongCan()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 3);
            t.C = new Diem(3, 0);
           
            Assert.AreEqual(5,t.loaiTamGiac());
        }

        [Test]
        public void LaTamGiacVuong()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 3);
            t.C = new Diem(4, 0);

            Assert.AreEqual(4, t.loaiTamGiac());
        }

        [Test]
        public void LaTamGiacDeu()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(1, 0);
            t.C = new Diem(1.0*1/2, 1.0*Math.Sqrt(3)/2);

            Assert.AreEqual(2, t.loaiTamGiac());
        }

        [Test]
        public void LaTamGiacCan()
        {
            t.A = new Diem(-3, 0);
            t.B = new Diem(0, 5);
            t.C = new Diem(3, 0);

            Assert.AreEqual(3, t.loaiTamGiac());
        }

        [Test]
        public void LaTamGiacThuong()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(1, 2);
            t.C = new Diem(4, 0);

            Assert.AreEqual(1, t.loaiTamGiac());
        }

        [Test]
        public void KhongLaTamGiacKhongDiemTrung()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 3);
            t.C = new Diem(0, 6);

            Assert.AreEqual(0, t.loaiTamGiac());
        }

        [Test]
        public void KhongLaTamGiacCoDiemTrung()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 0);
            t.C = new Diem(5, 6);

            Assert.AreEqual(0, t.loaiTamGiac());
        }

        [Test]
        public void ChuViTamGiacVuongCan()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 3);
            t.C = new Diem(3, 0);

            Assert.AreEqual(6 + Math.Sqrt(18), t.chuVi());
        }

        [Test]
        public void ChuViTamGiacVuong()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 3);
            t.C = new Diem(4, 0);

            Assert.AreEqual(12, t.chuVi());
        }

        [Test]
        public void ChuViTamGiacDeu()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(1, 0);
            t.C = new Diem(1.0 * 1 / 2, 1.0 * Math.Sqrt(3) / 2);

            Assert.AreEqual(3, t.chuVi());
        }

        [Test]
        public void ChuViTamGiacCan()
        {
            t.A = new Diem(-3, 0);
            t.B = new Diem(0, 4);
            t.C = new Diem(3, 0);

            Assert.AreEqual(16, t.chuVi());
        }

        [Test]
        public void ChuViTamGiacThuong()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(1, 2);
            t.C = new Diem(4, 0);

            Assert.AreEqual(Math.Sqrt(5) + Math.Sqrt(13) + 4, t.chuVi());
        }

        [Test]
        public void ChuViKhongLaTamGiacKhongDiemTrung()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 3);
            t.C = new Diem(0, 6);

            Assert.AreEqual(0, t.chuVi());
        }

        [Test]
        public void ChuViKhongLaTamGiacCoDiemTrung()
        {
            t.A = new Diem(0, 0);
            t.B = new Diem(0, 0);
            t.C = new Diem(5, 6);

            Assert.AreEqual(0, t.chuVi());
        }
    }
}

