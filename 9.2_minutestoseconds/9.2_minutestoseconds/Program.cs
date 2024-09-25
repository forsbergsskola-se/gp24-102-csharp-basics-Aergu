// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter a number. It will be converted from minutes to seconds shortly.");

string input = Console.ReadLine();

int minutes = int.Parse(input);

int ConvertedInteger = minutes * 60;

Console.WriteLine(input + " minutes is " + ConvertedInteger + " seconds.");