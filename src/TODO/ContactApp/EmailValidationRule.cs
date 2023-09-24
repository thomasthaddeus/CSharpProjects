using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace ContactApp
{
    public class EmailValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
        string? email = value as string;
        if (string.IsNullOrEmpty(email))
        {
        return new ValidationResult(false, "Email address cannot be empty.");
        }

        string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        if (!Regex.IsMatch(email, pattern))
        {
        return new ValidationResult(false, "Invalid email address format.");
        }

        return ValidationResult.ValidResult;
        }
    }
}