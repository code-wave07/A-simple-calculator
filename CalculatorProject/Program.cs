// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, User!");
Console.WriteLine("Welcome to the calculator");

try
{
    Console.WriteLine("Input your first value");
    int one = Convert.ToInt32(Console.ReadLine());

    

    Console.WriteLine("Input your second value");
    int two = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Available operations are; *, /, +, -.");
    string answer = Console.ReadLine();



    switch (answer)
    {
        case ("*"):
            answer = "*";
            Console.WriteLine($"The answer is {one * two}");
            break;

        case ("/"):
            answer = "/";
            Console.WriteLine($"The answer is {one / two}");
            break;

        case ("+"):
            answer = "+";
            Console.WriteLine($"The answer is {one + two}");
            break ;

        case ("-"): 
            answer = "-";
            Console.WriteLine($"The answer is {one - two}");
            break;

    }
}

catch
{
    Console.WriteLine("Invalid operation");
}