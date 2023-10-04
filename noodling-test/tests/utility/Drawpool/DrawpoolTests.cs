using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noodling_test.tests.utility.Drawpool
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DrawThreeTest()
        {
            List<int> list = new List<int>() { 4, 5, 6 };
            var sut = new noodling.src.utility.Drawpool<int>(list);
            int int1 = sut.draw();
            int int2 = sut.draw();
            int int3 = sut.draw();

            Assert.That(int1, Is.Not.EqualTo(int2));
            Assert.That(int1, Is.Not.EqualTo(int3));
            Assert.That(int2, Is.Not.EqualTo(int3));
            
        }
    }
}
