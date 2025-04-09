using System;
using System.Text.RegularExpressions;
using System.Linq;

string password;

Console.Clear();

Console.WriteLine("Adgangskoden skal mindst have 2 tal, et af de følgende special tegn ('!', '@', '#', '$', '%', '&', '*')");
Console.WriteLine("Længden skal mindst være på 8 tegn");
Console.Write("Indast dit nye kodeord: ");
password = Console.ReadLine();


if (PasswordValidator.ValidatePassword(password))
{
    Console.WriteLine("Stærk");
}
else
{
    Console.WriteLine("Svag");
}

public class PasswordValidator
{
    public static bool ValidatePassword(string password)
    {
        bool result = false;
        result = password.Length >= 8
        && Regex.IsMatch(password, @"\d.*\d")
        && Regex.IsMatch(password, @"[!@#$%&*].*[!@#$%&*]");
        
        return result;
    }
}