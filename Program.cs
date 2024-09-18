// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("What is your Name");
var a = Console.ReadLine();
Console.WriteLine("My name is " + a);
Add();

void Add()
{
    int x, b, c;
    Console.WriteLine(a + ", " + "Please enter 2 integers to add:");
    x = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());

    c = x + b;
    Console.WriteLine(a + ", " +"Addition is = " + c);
}

 