// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter a number. It will be converted from seconds to minutes shortly.");

int input = int.Parse(Console.ReadLine());

int ConvertedInterger = input / 60;

int RemaniningSeconds = input % 60;

Console.WriteLine(ConvertedInterger + " minute(s) and " + RemaniningSeconds + " second(s).");