using System.Net.Http.Headers;

Console.WriteLine("Please input the desired size of your triangle:");

retry:

bool parsed = int.TryParse(Console.ReadLine(), out int triangle);

if (!parsed)
{
    Console.WriteLine("Please try only with numerical values.");
    
}
