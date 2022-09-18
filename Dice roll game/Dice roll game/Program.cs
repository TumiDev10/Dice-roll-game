// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information


Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;


Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You scored a double! You get two extra points");
    total += 2;
    Console.WriteLine($"New total: {total}");
}

else if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You scored a triple! You get a bonus of 6 points");
    total += 6;
    Console.WriteLine($"New total: {total}");
}

if ((total >= 10) && (total < 15))
{
    Console.WriteLine("Congradulations! You won yourself an iPhone.");
}

if (total >= 15)
{
    Console.WriteLine("Congradulations! You won yourself a car.");
}

else
{
    Console.WriteLine("Thank you for playing");
}
