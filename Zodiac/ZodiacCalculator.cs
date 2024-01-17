using System.Net.Http.Headers;

namespace Zodiac
{
    public class ZodiacCalculator
    {
        public static string GetZodiacSign(int day, int month)
        {
            switch (month)
            {
                case 1: //jan
                    if (day <= 19)
                        return "Capricorn"; //Ma Kết
                    else
                        return "Aquarius"; //Bào Bình
                case 2: //feb
                    if (day <= 18)
                        return "Aquarius"; //Bào Bình
                    else
                        return "Pisces"; //Song Ngư
 
                case 3: //mar
                    break;

                default:
                    break;

            }
        }
    }
}
