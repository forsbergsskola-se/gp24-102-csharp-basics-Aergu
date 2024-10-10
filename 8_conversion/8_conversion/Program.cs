// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Give me a number.");

string input = Console.ReadLine(); //Gör så att användaren kan skriva siffror/bokstäver

Console.WriteLine(input);

int number = int.Parse(input, CultureInfo.InvariantCulture);

Console.WriteLine(number);