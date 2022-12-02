using System.Text.RegularExpressions;

var email = "testnet7esencial.com";
System.Console.WriteLine(RegexDemo.Match(email));

public partial class RegexDemo
{
    [GeneratedRegex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")]
    public static partial Regex TheRegex();

    public static bool Match(string text)
    {
        return TheRegex().IsMatch(text);
    }
}