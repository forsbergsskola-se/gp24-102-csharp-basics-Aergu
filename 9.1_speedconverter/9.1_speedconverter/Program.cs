// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please enter a number. It will be converted from km/h to m/s shortly.");

string input = Console.ReadLine();

int Kmperhour = int.Parse(input);

int ConvertedKmh = (int)(Kmperhour / 3.6f);

Console.WriteLine("m/s is " + ConvertedKmh);