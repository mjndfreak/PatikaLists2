// See https://aka.ms/new-console-template for more information

List<string> coffees = new List<string>();

Console.Write("Coffee 1: ");
coffees.Add(Console.ReadLine());
Console.Write("Coffee 2: ");
coffees.Add(Console.ReadLine());
Console.Write("Coffee 3: ");
coffees.Add(Console.ReadLine());
Console.Write("Coffee 4: ");
coffees.Add(Console.ReadLine());
Console.Write("Coffee 5: ");
coffees.Add(Console.ReadLine());

Console.WriteLine("**** Coffees ****");

for (int i = 0; i < coffees.Count; i++)
{
    Console.WriteLine("Coffee " + (i +1) + ": " + coffees[i]);
}


