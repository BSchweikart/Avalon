using System;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumGen
    {
        private static readonly RNGCryptoServiceProvider _generate = new RNGCryptoServiceProvider();

        public static int NumberBetween(int miniValue, int maxiValue)
        {
            byte[] randNumber = new byte[1];

            _generate.GetBytes(randNumber);

            double asciiValueofRandomCharacter = Convert.ToDouble(randNumber[0]);

            double multiplier = Math.Max(0, (asciiValueofRandomCharacter / 255d) - 0.00000000001d);

            int range = maxiValue - miniValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(miniValue + randomValueInRange);
        }
    }
}
