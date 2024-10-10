// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please, enter a number. It's negation will be shown shortly.");

int input = int.Parse(Console.ReadLine());

input -= input + input;


Console.WriteLine(input);

