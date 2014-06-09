using NUnit.Framework;

namespace Dinobenz.ThaiNumberSpelling.Test
{
    [TestFixture]
    public class NumberExtensionTest
    {
        int number;

        [Test]
        public void Zero()
        {
            number = 0;

            var expected = "ศูนย์";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void One()
        {
            number = 1;

            var expected = "หนึ่ง";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Two()
        {
            number = 2;

            var expected = "สอง";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Three()
        {
            number = 3;

            var expected = "สาม";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Eleven()
        {
            number = 11;

            var expected = "สิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TwentyOne()
        {
            number = 21;

            var expected = "ยี่สิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneHundredEleven()
        {
            number = 111;

            var expected = "หนึ่งร้อยสิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TwoHundredEleven()
        {
            number = 211;

            var expected = "สองร้อยสิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneThousandOneHundredEleven()
        {
            number = 1111;

            var expected = "หนึ่งพันหนึ่งร้อยสิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TenThousandOneHundredEleven()
        {
            number = 11111;

            var expected = "หนึ่งหมื่นหนึ่งพันหนึ่งร้อยสิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneHundredThousandOneHundredEleven()
        {
            number = 111111;

            var expected = "หนึ่งแสนหนึ่งหมื่นหนึ่งพันหนึ่งร้อยสิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OneMillionOneHundredThousandOneHundredElevenEleven()
        {
            number = 1111111;

            var expected = "หนึ่งล้านหนึ่งแสนหนึ่งหมื่นหนึ่งพันหนึ่งร้อยสิบเอ็ด";
            var actual = number.ToThaiSpelling();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Billion_321000321() {
          number = 321000321;

          var expected = "สามร้อยยี่สิบเอ็ดล้านสามร้อยยี่สิบเอ็ด";
          var actual = number.ToThaiSpelling();

          Assert.AreEqual(expected, actual);
        }
    }
}
