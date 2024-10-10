// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input 2 numbers.");

int input = int.Parse(Console.ReadLine());

int input2 = int.Parse(Console.ReadLine());

int hypotenuse = (input * input) + (input2 * input2);

double squarehypotenuse = hypotenuse;
double squareRoot = Math.Sqrt(hypotenuse);

Console.WriteLine("The square root is: " + squareRoot);