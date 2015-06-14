using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BTVN_1_Hiep;

namespace Testing
{
    [TestFixture]
    class HiepTesting
    {
        [Test]
        public void TestIsPrime()
        {
            InputNumber n = new InputNumber();
            bool result = n.isPrime(3);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void TestCheckNumberChar()
        {
            InputNumber n = new InputNumber();

            int count = n.checkNumberChar("Kim sieu vong ba", 'i');

            Assert.AreEqual(2, count);
        }
    }
}
