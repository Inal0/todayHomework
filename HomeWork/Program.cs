

using System;
using System.Linq;

public class User

{
    private string _username{ get; set; }

    public string UserName
    {
        get { return _username; }
        set
        {
            if (value.Length > 6)
            {
                _username = value;
            }
            else
            {
                Console.WriteLine("Username must not exceed the usual 6 characters.");
            }
        }
    }

    private string _password { get; set; }
    public string Password
    {
        get { return _password; }
        set
        {
            if (value.Any(char.IsDigit) && value.Any(char.IsUpper))
            {
                _password = value;
            }
            else
            {
                System.Console.WriteLine("Password must contain at least 1 number and at least 1 uppercase letter");
            }
        }
    }
}