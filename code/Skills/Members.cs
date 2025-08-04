namespace Skills;

public class Members
{
    public string Name { get; set; }

    public string Role { get; set; }

    public string Age { get; set; }

    public Members(string name, string role, string age)
    {
        Name = name;
        Role = role;
        Age = age;
    }
}
