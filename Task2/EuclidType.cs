using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task2
{
    public class EuclidType
    {
        private delegate int NodCalc(int numb1, int numb2);
        public static int NodByEuclid(int firstNumb, int secondNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = NodByEuclid(firstNumb, secondNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByEuclid(int firstNumb, int secondNumb)
        {
            NodCalc nodCalc = new NodCalc(CalcNodByEuclidAlgorithm);
            int nod = nodCalc(firstNumb, secondNumb);
            return nod;
        }
        public static int NodByEuclid(int firstNumb, int secondNumb, int thirdNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = NodByEuclid(firstNumb, secondNumb, thirdNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByEuclid(int firstNumb, int secondNumb, int thirdNumb)
        {
            NodCalc nodCalc = new NodCalc(CalcNodByEuclidAlgorithm);
            int nod = nodCalc(firstNumb, secondNumb);
            nod = nodCalc(nod, thirdNumb);
            return nod;
        }
        public static int NodByEuclid(out int milliSeconds, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (numbers == null)
            {
                stopwatch.Stop();
                milliSeconds = stopwatch.Elapsed.Milliseconds;
                throw new NullReferenceException();
            }
            if (numbers.Length < 2)
            {
                stopwatch.Stop();
                milliSeconds = stopwatch.Elapsed.Milliseconds;
                throw new ArgumentException();
            }
            int nod = NodByEuclid(numbers);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByEuclid(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new NullReferenceException();
            }
            if (numbers.Length < 2)
            {
                throw new ArgumentException();
            }
            NodCalc nodCalc = new NodCalc(CalcNodByEuclidAlgorithm);
            int numbersCounter = 0;
            int numb1 = numbers[numbersCounter++];
            int nod = numb1;
            while (numbersCounter < numbers.Length)
            {
                int numb2 = numbers[numbersCounter++];
                nod = nodCalc(numb1, numb2);
                numb1 = nod;
            }
            return nod;
        }

        public static int NodByStein(int firstNumb, int secondNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = NodByStein(firstNumb, secondNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByStein(int firstNumb, int secondNumb)
        {
            NodCalc nodCalc = new NodCalc(CalcNodByStein);
            int nod = nodCalc(firstNumb, secondNumb);
            return nod;
        }
        public static int NodByStein(int firstNumb, int secondNumb, int thirdNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = NodByStein(firstNumb, secondNumb, thirdNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByStein(int firstNumb, int secondNumb, int thirdNumb)
        {
            NodCalc nodCalc = new NodCalc(CalcNodByStein);
            int nod = nodCalc(firstNumb, secondNumb);
            nod = nodCalc(nod, thirdNumb);
            return nod;
        }
        public static int NodByStein(out int milliSeconds, params int[] numbers)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (numbers == null)
            {
                stopwatch.Stop();
                milliSeconds = stopwatch.Elapsed.Milliseconds;
                throw new NullReferenceException();
            }
            if (numbers.Length < 2)
            {
                stopwatch.Stop();
                milliSeconds = stopwatch.Elapsed.Milliseconds;
                throw new ArgumentException();
            }
            int nod = NodByStein(numbers);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByStein(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new NullReferenceException();
            }
            if (numbers.Length < 2)
            {
                throw new ArgumentException();
            }
            NodCalc nodCalc = new NodCalc(CalcNodByStein);
            int numbersCounter = 0;
            int firstNumb = numbers[numbersCounter++];
            int nod = firstNumb;
            while (numbersCounter < numbers.Length)
            {
                int secondNumb = numbers[numbersCounter++];
                nod = nodCalc(firstNumb, secondNumb);
                firstNumb = nod;
            }
            return nod;
        }
        private static int CalcNodByEuclidAlgorithm(int firstNumb, int secondNumb)
        {
            while (secondNumb != 0)
            {
                int temp = secondNumb;
                secondNumb = firstNumb % secondNumb;
                firstNumb = temp;
            }
            return firstNumb;
        }
        private static int CalcNodByStein(int firstNumb, int secNumb)
        {
            if (firstNumb == 0) return secNumb;
            if (secNumb == 0) return firstNumb;
            if (firstNumb == secNumb) return firstNumb;
            if (firstNumb == 1 || secNumb == 1) return 1;
            if ((firstNumb % 2 == 0) && (secNumb % 2 == 0)) return 2 * CalcNodByStein(firstNumb / 2, secNumb / 2);
            if ((firstNumb % 2 == 0) && (secNumb % 2 != 0)) return CalcNodByStein(firstNumb / 2, secNumb);
            if ((firstNumb % 2 != 0) && (secNumb % 2 == 0)) return CalcNodByStein(firstNumb, secNumb / 2);
            return CalcNodByStein(secNumb, (int)Math.Abs(firstNumb - secNumb));
        }
    }
}
