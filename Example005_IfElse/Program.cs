Console.Write("Input your username: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Is That You, Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}
