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

Console.WriteLine("Enter two numbers:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Results:");
CalculateNumbers(number1, number2);
SubstractNumbers(number1, number2);
