// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number of seconds.");

string input = Console.ReadLine();

int Seconds = int.Parse(input);

int ConvertToDays = Seconds / 86400;

int SecondsRemaining = Seconds % 86400;

int ConvertToHours = SecondsRemaining / 3600;

SecondsRemaining %= 3600;

int ConvertToMinutes = SecondsRemaining / 60;

int ConvertToSeconds = SecondsRemaining % 60;

Console.WriteLine("Days: " + ConvertToDays);
Console.WriteLine("Hours: " + ConvertToHours);
Console.WriteLine("Minutes: " + ConvertToMinutes);
Console.WriteLine("Seconds: " + ConvertToSeconds);

Console.WriteLine($"{ConvertToDays} .  {ConvertToHours} : {ConvertToMinutes} : {ConvertToSeconds}");

Console.WriteLine($"In total that is {(float)Seconds / 86400} days.");


