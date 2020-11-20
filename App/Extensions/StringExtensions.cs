using System;

namespace App.Extensions
{
    public static class StringExtensions
    {
        public static string Sort(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            var array = text.ToCharArray();
            Array.Sort(array);
            return new string(array);
        }

        public static string Reverse(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }

            var array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static bool IsPalindrome(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

            return text == text.Reverse().ToString();
        }
    }
}
