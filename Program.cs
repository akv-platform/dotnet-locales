using System;
using System.Globalization;

namespace dotnet_locales
{
    class Program
    {
        static void Main(string[] args)
        {
	    CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo culture in cultures)
            {
               Console.WriteLine(culture.Name);
            }
        }
    }
}
