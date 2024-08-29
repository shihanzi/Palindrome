// See https://aka.ms/new-console-template for more information

Console.WriteLine("please type");
string input = Console.ReadLine();
var reversedString = Reverse(input);

if (input == reversedString)
{
    Console.WriteLine("It is a plaindrome");

}
else
{
    Console.WriteLine("It is not a plaindrome");

}

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

