void CalculateNumbers(int var1, int var2)
{
    int sum = var1 + var2;
    Console.WriteLine($"Sum: {sum}");
}

void SubstractNumbers(int var1, int var2)
{
    int difference = var1 - var2;
    Console.WriteLine($"Difference: {difference}");
}

//create a method that takes two numbers as input and prints their multiplication, check for division by zero
void MultiplyNumbers(int var1, int var2)
{
    if (var2 == 0)
    {
        Console.WriteLine("Cannot multiply by zero.");
        return;
    }
    int product = var1 * var2;
    Console.WriteLine($"Product: {product}");
}

Console.WriteLine("Enter two numbers:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Results:");
CalculateNumbers(number1, number2);
SubstractNumbers(number1, number2);
MultiplyNumbers(number1, number2);