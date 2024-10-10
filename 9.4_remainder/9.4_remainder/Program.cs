// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter two numbers that will be divided. The remainder of the division will be outputted shortly.");

int input = int.Parse(Console.ReadLine());

int input2 = int.Parse(Console.ReadLine());

double answer = input % input2;

Console.WriteLine(answer);