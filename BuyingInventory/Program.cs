//display the menu
using System.Diagnostics;

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing equipment");
Console.WriteLine("4 - Clean water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

//ask the user to enter a number from menu
Console.Write("What number do you want to see the price of? ");
int numberFromMenu = Convert.ToInt32(Console.ReadLine());

//display the cost for the item from menu using switch statement
switch (numberFromMenu)
{
    case 1: Console.WriteLine("The Rope price is " + 10);
        break;
    case 2: Console.WriteLine("The Torches price is " + 15);
        break;
    case 3: Console.WriteLine("The Climbing equipment price is " + 25);
        break;
    case 4: Console.WriteLine("The Clean water price is " + 1);
        break;
    case 5: Console.WriteLine("The Machete price is " + 20);
        break;
    case 6: Console.WriteLine("The Canoe price is " + 200);
        break;
    case 7: Console.WriteLine("The Food Supplies price is " + 10);
        break;
}

//display the cost for the item from menu using switch expression
string response;
response = numberFromMenu switch
{
    1 => "The Rope price is " + 10,
    2 => "The Torches price is " + 15,
    3 => "The Climbing equipment price is " + 25,
    4 => "The Clean water price is " + 1,
    5 => "The Machete price is " + 20,
    6 => "The Canoe price is " + 200,
    7 => "The Food Supplies price is " + 10,
};
Console.WriteLine(response);