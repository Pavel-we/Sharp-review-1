using System;

namespace Home_work_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        #region Integer

       public static int Integer3(int FileSizeInBytes = 100) => FileSizeInBytes / 1024;

       public static (int,int) Integer6(int TwoDigitNumber)
        {
            int FirstNumber = TwoDigitNumber / 10;
            int SecondNumber = TwoDigitNumber % 10;
            return (FirstNumber, SecondNumber);
        }

        public static int Integer9(int YourNumber) => YourNumber / 10;

        public static int Integer12(int InvertedNumber)
        {
            int FirstNumber = InvertedNumber / 100;
            int SecondNumber = (InvertedNumber % 100 / 10) * 10;
            int ThirdNumber = (InvertedNumber % 10) * 100;
            int YourNumber = ThirdNumber + SecondNumber + FirstNumber;
            return YourNumber;
        }
        public static int Integer15(int YourNumber)
        {
            int SecondNumber = YourNumber % 100 / 10;
            int ThirdNumber = YourNumber / 100;
            int FirstNumber = YourNumber % 10;
            int InvertedNumber = ThirdNumber * 100 + SecondNumber * 10 + FirstNumber;
            return InvertedNumber;
        }

        public static int Integer18(int NumberDigit) => NumberDigit % 10000 / 1000;
        public static int Integer21(int Seconds) => Seconds % 60;
        public static int Integer24(int DayOfTheWeek) => DayOfTheWeek % 7;
        public static int Integer27(int DayOfTheWeekNumber) => ((DayOfTheWeekNumber + 4) % 7) + 1;
        public static int Integer30(int CenturyNumber) => (CenturyNumber / 100) + 1;
        #endregion
        #region Boolean

        public static bool Boolean3(int Number) => Number % 2 == 0;
        public static bool Boolean6(int a, int b, int c) => a < b && b < c;
        public static bool Boolean9(int a, int b) => a % 2 != 0 || b % 2 != 0;
        public static bool Boolean12(int a, int b, int c) => a >= 0 && b >= 0 && c >= 0;
        public static bool Boolean15(int a, int b, int c) => (a >= 0 && b >= 0 && c <= 0) || (a <= 0 && b >= 0 && c >= 0) || (a >= 0 && b <= 0 && c >= 0);
        public static bool Boolean18(int a, int b, int c) => (a == b) && (b == c) && (c == a)
        public static bool Boolean21(int Number)
        {
            int FirstNumber = Number % 10;
            int SecondNumber = Number % 100 / 10;
            int ThirdNumber = Number / 100;
            return ThirdNumber < SecondNumber && SecondNumber < FirstNumber;
        }
        public static bool Boolean24(int a, int b, int c) => (b * b) - (4 * a * c) > 0;
        public static bool Boolean27(int x, int y) => (x <= 0) || (x <= 0 && y <= 0);
        public static bool Boolean30(int a, int b, int c) => (a == b) && (b == c);
        public static bool Boolean33(int a, int b, int c) => (a < b + c) && (b < a + c) && (c < a + b);
        public static bool Boolean36(int x1, int y1, int x2, int y2) => (x1 == x2) || (y1 == y2);
        public static bool Boolean39(int x1, int y1, int x2, int y2) => ((x1 - x2) == (y1 - y2)) || ((-1) * (y1 - y2)) || (x1 == x2) || (y1 == y2);
        #endregion
        #region If

        public static int If3(int IntegerNumber)
        {
            if (IntegerNumber > 0) IntegerNumber++;
            else if (IntegerNumber < 0) IntegerNumber = IntegerNumber - 2;
            else IntegerNumber = 10;
            return IntegerNumber;
        }
        public static int If6(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        public static int If9(int a, int b)
        {
            if (a > b)
            {
                a = b + b;
                b = a - b;
                a = a - b;
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int If12(int a, int b, int c)
        {
            int Minimum = a;
            if (b < Minimum) Minimum = b;
            if (c < Minimum) Minimum = c;
            return Minimum;
        }
        static (string, int) GetMinimun (int a, int b, int c)
        {
           if(a >= b && a >= c) return a;
           if (b >= c) return b;
           return c;
        }
        public static int? If18(int a, int b, int c)
        {
            if (a == b) return a;
            else if (b == c) return b;
            else if (a == c) return c;
            else return null;
        }
        public static int? If21(int x, int y)
        {
            if (x == 0 && y == 0) return x;
            else if ((x != 0 && x == 0) || (y != 0 && y == 0)) return y;
            else if ((x != 0) || (y != 0)) return x;
            else return null;
        }
        public static float If24(float Number)
        {
            if (Number > 0)
            {
                float NumberF = 2 * Math.Sin(Number);
                return NumberF;
            }
            else
            {
                float NumberF = 6 - Number;
                return NumberF;
            }
        }
        public static float If27(float Number)
        {
            if (Number < 0)
            {
                float NumberF = 0;
            }
            else if ((Number % 2) == 0)
            {
                float NumberF = 1;
            } 
            else
            {
                float NumberF = -1;
                return NumberF;
            } 
        }
        public static int? If30(int Number)
        {
            if (Number % 2 == 0) return Number;
            else return null;
            if (Number > 99) return Number;
            else if ((99 > Number) && (Number > 9)) return (Number + Number);
            else if (Number <= 9) return null;
        }
        #endregion
    }
}
