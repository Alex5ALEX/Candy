using System.Text.RegularExpressions;

namespace CandyClient.Logic;

public class Validation
{
    public bool ValidatePhone(string str)
    {
        Regex tel_pattern = new Regex(@"^[+]?[0-9]{6,12}$");

        return tel_pattern.IsMatch(str);
    }

    public bool ValidateEmail(string email)
    {
        Regex emailPattern = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

        return emailPattern.IsMatch(email);
    }
}