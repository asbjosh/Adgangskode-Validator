bool passwordSecure = true;
string password;

do
{
    Console.Clear();

    Console.WriteLine("Adgangskoden skal mindst have 2 tal, et af de følgende special tegn ('!', '@', '#', '$', '%', '&', '*')");
    Console.WriteLine("Længden skal mindst være på 8 tegn");
    Console.Write("Indast dit nye kodeord: ");
    password = Console.ReadLine();

    passwordSecure = false;

    if(password.Length < 2)
    {
        Console.WriteLine();
    }

} while(passwordSecure);