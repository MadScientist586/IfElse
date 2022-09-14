var r = new Random();
var favNumber = r.Next(1, 1000);
while (true)
{
    Console.WriteLine("Guess the number:");
    var userInput = int.Parse(Console.ReadLine());


    if (userInput < favNumber)
    {
        Console.WriteLine("too low");
    }
    else if (userInput > favNumber)
    {
        Console.WriteLine("too high");
    }
    else if (userInput == favNumber)
    {
        Console.WriteLine("You guessed it!!!!");
    }
}