using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Retrovizor.Data.Entities.Models;

namespace Retrovizor.Domain.Helpers
{
    public static class CredentialsHelper
    {
        public static string TrimAndRemoveMultipleWhiteSpaces(this string text)
        {
            text = text.Trim();
            var regex = new Regex(@"\s{2,}");
            while (regex.IsMatch(text))
                text = regex.Replace(text, " ", 1);
            return text;
        }

        public static bool CheckForForbiddenCharacters(this string text)
        {
            var forbiddenCharacters = "-ß¤+!§łŁ×÷€\\@#$%^&*(),.?\"':}{<>|";

            foreach (var character in forbiddenCharacters)
            {
                if (text.Contains(character.ToString()))
                    return false;
            }

            return true;
        }

        public static string FirstLetterCapitalization(this string text)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
        }

        public static string NameFormatting(this string text)
        {
            var formattedString = TrimAndRemoveMultipleWhiteSpaces(text);
            return FirstLetterCapitalization(formattedString);
        }

        public static string GenerateUsername(string firstName, string lastName, List<User> users)
        {
            return firstName[0] + lastName;
        }

        public static string GenerateRandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int z = 0; z < random.Next(6, 10); z++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            var pass = builder.ToString().ToLower();
            return pass;
        }
    }
}
