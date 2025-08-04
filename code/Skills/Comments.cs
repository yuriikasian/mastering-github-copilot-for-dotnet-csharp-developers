namespace Skills;

internal class Comments
{
    //Create a method that generates a comment for a given skill
    public static string GenerateComment(string skillName, int skillLevel)
    {
        if (skillLevel < 1 || skillLevel > 5)
        {
            return "Invalid skill level. Please provide a level between 1 and 5.";
        }
        return $"Skill: {skillName}, Level: {skillLevel} - Keep up the good work!";
    }
}
