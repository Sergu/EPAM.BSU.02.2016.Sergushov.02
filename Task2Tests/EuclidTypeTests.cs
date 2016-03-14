using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2Tests
{
    [TestClass]
    public class EuclidTypeTests
    {
        [TestMethod]
        public void NodByEuclid_NodOf240And120_return120()
        {
            int time;
            int firstNumb = 240;
            int secNumb = 120;
            int result = 120;
            Assert.AreEqual(EuclidType.NodByEuclid(firstNumb, secNumb,out time), result);
        }
        [TestMethod]
        public void NodByEuclid_elapsedTimeChecked_returnMoreThanZero()
        {
            int time;
            int firstNumb = 240;
            int secNumb = 120;
            EuclidType.NodByEuclid(firstNumb, secNumb, out time);
            Assert.IsTrue(time >= 0);
        }
        [TestMethod]
        public void NodByEuclid_NodOf240And120and60_return60()
        {
            int time;
            int firstNumb = 240;
            int secNumb = 120;
            int thirdNumb = 60;
            int result = 60;
            Assert.AreEqual(EuclidType.NodByEuclid(firstNumb,secNumb,thirdNumb,out time),result);
        }
        [TestMethod]
        [ExpectedException (typeof(NullReferenceException))]
        public void NodByEuclid_nullRefChecked_returnException()
        {
            int time;
            int[] numbers = null;
            EuclidType.NodByEuclid(out time, numbers);
        }
        [TestMethod]
        [ExpectedException (typeof(ArgumentException))]
        public void NodByEuclid_oneParamChecked_returnArgumentException()
        {
            int time;
            int firstNumb = 234;
            EuclidType.NodByEuclid(out time, firstNumb);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NodByEuclid_zeroParamsChecked_returnArgumentException()
        {
            int time;
            int[] numbers = new int[0];
            EuclidType.NodByEuclid(out time, numbers);
        }
        [TestMethod]
        public void NodByEuclid_nodOfSixNumbers_returnTrueNod()
        {
            int time;
            int[] numbers = new int[]{ 132, 867, 123, 936, 312, 699 };
            int result = 3;
            Assert.AreEqual(EuclidType.NodByEuclid(out time, numbers), result);
        }





        [TestMethod]
        public void NodByStein_NodOf240And120_return120()
        {
            int time;
            int firstNumb = 240;
            int secNumb = 120;
            int result = 120;
            Assert.AreEqual(EuclidType.NodByStein(firstNumb, secNumb, out time), result);
        }
        [TestMethod]
        public void NodByStein_elapsedTimeChecked_returnMoreThanZero()
        {
            int time;
            int firstNumb = 240;
            int secNumb = 120;
            EuclidType.NodByStein(firstNumb, secNumb, out time);
            Assert.IsTrue(time >= 0);
        }
        [TestMethod]
        public void NodByStein_NodOf240And120and60_return60()
        {
            int time;
            int firstNumb = 240;
            int secNumb = 120;
            int thirdNumb = 60;
            int result = 60;
            Assert.AreEqual(EuclidType.NodByStein(firstNumb, secNumb, thirdNumb, out time), result);
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NodByStein_nullRefChecked_returnException()
        {
            int time;
            int[] numbers = null;
            EuclidType.NodByStein(out time, numbers);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NodByStein_oneParamChecked_returnArgumentException()
        {
            int time;
            int firstNumb = 234;
            EuclidType.NodByStein(out time, firstNumb);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NodByStein_zeroParamsChecked_returnArgumentException()
        {
            int time;
            int[] numbers = new int[0];
            EuclidType.NodByStein(out time, numbers);
        }
        [TestMethod]
        public void NodByStein_nodOfSixNumbers_returnTrueNod()
        {
            int time;
            int[] numbers = new int[] { 132, 867, 123, 936, 312, 699 };
            int result = 3;
            Assert.AreEqual(EuclidType.NodByStein(out time, numbers), result);
        }

    }
}
