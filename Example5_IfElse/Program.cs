Console.Write("Enter your name ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hello, darling!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
}