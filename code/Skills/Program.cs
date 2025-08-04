void CalculateNumbers(int a, int b, out int sum)
{
    sum = a + b;
    Console.WriteLine($"The sum of {a} and {b} is {sum}.");
}

void SubstractNumbers(int a, int b, out int difference)
{
    difference = a - b;
    Console.WriteLine($"The difference between {a} and {b} is {difference}.");
}

Console.WriteLine("Enter two numbers to perform calculations:");
Console.Write("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter second number: "); 
int secondNumber = int.Parse(Console.ReadLine() ?? "0");
CalculateNumbers(firstNumber, secondNumber, out int sum);
SubstractNumbers(firstNumber, secondNumber, out int difference);