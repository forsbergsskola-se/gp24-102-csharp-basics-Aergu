// See https://aka.ms/new-console-template for more information

Console.WriteLine("What's your age?");

int input = int.Parse(Console.ReadLine());

bool isAChild = input < 13;

    Console.WriteLine($"You are a child: {isAChild}");


bool isATeenager = input >13 && input < 20;

    Console.WriteLine($"You are a teenager: {isATeenager}");

bool isAnAdult = input > 19;

    Console.WriteLine($"You are an adult: {isAnAdult}");









