// See https://aka.ms/new-console-template for more information

Console.WriteLine("Input your weight and height so that your BMI can be calculated.");

int inputWeight = int.Parse(Console.ReadLine());

int inputHeight = int.Parse(Console.ReadLine());

int bmi = inputWeight / (inputHeight * inputHeight);

Console.WriteLine(bmi);