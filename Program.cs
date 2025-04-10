using System;
using System.Text.RegularExpressions;
using System.Linq;

string password;
bool isValid = true;
do
{
    Console.Clear();

    Console.WriteLine("Adgangskoden skal mindst have 2 tal, et af de følgende special tegn ('!', '@', '#', '$', '%', '&', '*')");
    Console.WriteLine("Længden skal mindst være på 8 tegn");
    Console.Write("Indast dit nye kodeord: ");
    password = Console.ReadLine();


    if (PasswordValidator.ValidatePassword(password))
    {
        Console.WriteLine("Stærk");
        isValid = false;
    }
    else
    {
        Console.WriteLine("Svag");
    }
} while (isValid);


public class PasswordValidator
{
    public static bool ValidatePassword(string password)
    {
        bool result = false;
        result = password.Length >= 8
        && Regex.IsMatch(password, @"(?:.*\d){2,}")
        && Regex.IsMatch(password, @"(?:.*[!@#$%&*]){2,}");

        return result;
    }
}