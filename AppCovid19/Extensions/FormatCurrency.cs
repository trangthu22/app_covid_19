using System.Globalization;

namespace AppCovid19.Extensions
{
    public class FormatCurrency
    {
        public static string FormatIntToString(int number)
        {
            return number.ToString("0,0", CultureInfo.CreateSpecificCulture("is-IS"));
        }
    }
}