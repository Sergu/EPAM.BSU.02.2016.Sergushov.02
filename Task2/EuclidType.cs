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
        public static int NodByEuclid(int firstNumb, int secondNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = CalcNodByEuclidAlgorithm(firstNumb, secondNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByEuclid(int firstNumb, int secondNumb, int thirdNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = CalcNodByEuclidAlgorithm(firstNumb, secondNumb);
            nod = CalcNodByEuclidAlgorithm(nod, thirdNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
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

            int numbersCounter = 0;
            int paramA = numbers[numbersCounter++];
            int nod = paramA;
            while (numbersCounter < numbers.Length)
            {
                int paramB = numbers[numbersCounter++];
                nod = CalcNodByEuclidAlgorithm(paramA, paramB);
                paramA = nod;
            }
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }

        public static int NodByStein(int firstNumb, int secondNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = CalcNodByStein(firstNumb, secondNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
            return nod;
        }
        public static int NodByStein(int firstNumb, int secondNumb, int thirdNumb, out int milliSeconds)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int nod = CalcNodByStein(firstNumb, secondNumb);
            nod = CalcNodByStein(nod, thirdNumb);
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
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

            int numbersCounter = 0;
            int firstNumb = numbers[numbersCounter++];
            int nod = firstNumb;
            while (numbersCounter < numbers.Length)
            {
                int secondNumb = numbers[numbersCounter++];
                nod = CalcNodByStein(firstNumb, secondNumb);
                firstNumb = nod;
            }
            stopwatch.Stop();
            milliSeconds = stopwatch.Elapsed.Milliseconds;
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
