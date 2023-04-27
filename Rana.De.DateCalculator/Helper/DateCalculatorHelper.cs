namespace Rana.De.DateCalculator.Helper
{
    //Helper class 
    public static class DateCalculatorHelper
    {
        public static long ToJulian(int year, int month, int day)
        {
            if (month < 3)
            {
                month = month + 12;
                year = year - 1;
            }

            return day + (153 * month - 457) / 5 + 365 * year + (year / 4) - (year / 100) + (year / 400) + 1721119;
        }
        public static long ToJulian(string mdy)
        {
            var split = mdy.Split('/');
            return ToJulian(int.Parse(split[2]), int.Parse(split[0]), int.Parse(split[1]));
        }
    }
}
