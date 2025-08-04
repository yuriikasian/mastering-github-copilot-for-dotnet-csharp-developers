namespace Skills;

public class Members
{
    public string Name { get; set; }

    public string Role { get; set; }

    public string Age { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public Members(string name, string role, string age, string lastName, string firstName)
    {
        Name = name;
        Role = role;
        Age = age;
        LastName = lastName;
        FirstName = firstName;
    }

    public void ShowMember()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Role: {Role}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"First Name: {FirstName}");
    }
}
