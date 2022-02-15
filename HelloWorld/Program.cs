Console.WriteLine("Hello World");
string name;
do
{
    Console.Write("Input your first name: ");
    name = Console.ReadLine();
} while (name == "");
Console.WriteLine("Hello " + name);
Console.ReadLine();