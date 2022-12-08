//user input - ask for amount of people
Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
int people = int.Parse(Console.ReadLine());
//display blank line
Console.WriteLine(" ");

//determine if we have enough seating for parties up to six people
if (people <= 6)
{
    Console.WriteLine("A table for " + people + "! Please follow me and take a seat.");
    Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
    Console.WriteLine(" ");

    //ask each guest what they would like to drink and store it for later
    string[] coffees = new string[people];
    string[] waters = new string[people];
    for (int i = 0; i <= people - 1; i++)
    {
        Console.WriteLine("Alright, person number " + (i + 1) + ", water or coffee ?");
        string drink = (Console.ReadLine());
        if (drink.Equals("coffee", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine("Coffee, good choice!");
            coffees[i] = drink;
        }
        else if (drink.Equals("water", StringComparison.CurrentCultureIgnoreCase))
        {
            Console.WriteLine("Water, good choice!");
            waters[i] = drink;
        }
        else
        {
            Console.WriteLine("We don't have that. No drink for you!");
        }
        Console.WriteLine(" ");
    }

    //output total amount of drinks for party
    var totalcoffees = coffees.Count(s => s == "coffee");
    var totalwaters = waters.Count(s => s == "water");
    Console.WriteLine("Okay, so that's " + totalcoffees + " coffees and " + totalwaters + " waters. I'll be right back. Feel free to grab your food!");

    //caculate bill
    double buffetprice = 9.99;
    double coffeeprice = 2.00;
    Console.WriteLine(" ");
    Console.WriteLine("Here's your bill! Total price: $" + ((buffetprice * people) + (coffeeprice * totalcoffees)));
}
else
{
    Console.WriteLine("Oh sorry, we can only seat parties up to 6. Have a nice day.");
}