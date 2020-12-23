using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BTCN06.Test
{
    [TestFixture]
    public class DiemTest
    {
        Diem a;

        [SetUp]
        public void Setup()
        {
            a = new Diem(1,1);
        }

        [Test]
        public void KhoangCachDenChinhNo()
        {
            Assert.AreEqual(0, a.khoangCachDen(a));
        }

        [Test]
        public void KhoangCachDenDiemKhac()
        {
            Diem b = new Diem(1, 5);
            Assert.AreEqual(4, a.khoangCachDen(b));
        }
    }
}
