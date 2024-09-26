// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");

int input = int.Parse( Console.ReadLine());

bool isAnAdult = input > 19;
Console.WriteLine("You're an adult.");

Console.WriteLine("Give me another integer.");

int input2 = int.Parse(Console.ReadLine());

bool FirstNumberBiggerThanSecondNumber = input > input2;
if (FirstNumberBiggerThanSecondNumber)
{
    Console.WriteLine("The maximum is: " + input);
}

else
{
    Console.WriteLine("The maximum is: " + input2);
}

if (input % 2 == 0)
{
    Console.WriteLine("That number is an even number.");
}

else

    Console.WriteLine("That number is an odd number.");

