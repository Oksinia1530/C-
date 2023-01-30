Console.Write("Enter your name!");
string username = Console.ReadLine();
if(username.ToLower() == "pekka")
    Console.WriteLine("Kippis, tama on Pekka!");
else
    Console.Write("Terve, ");
    Console.WriteLine(username);