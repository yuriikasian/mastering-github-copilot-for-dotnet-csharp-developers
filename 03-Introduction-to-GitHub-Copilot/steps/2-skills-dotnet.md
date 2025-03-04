## Step 2: Seeing AI code suggestions in a C# file!

_Nice work! :tada: You created a Codespace using a devcontainer file that installed Copilot!_

GitHub Copilot provides suggestions for numerous languages and a wide variety of frameworks, but works especially well for Python, JavaScript, TypeScript, Ruby, Go, C# and C++. The following samples are in C#, but other languages will work similarly.

Let's try this out utilizing C# for Copilot.

> **Note**:
> If you closed the Codespace from above, please open it back up or create a new Codespace.

### ⌨️ Activity: Add a C# file and start writing code

> **Note**:
> Make sure to open the **Solution Explorer** to see an organized view to easily add new projects and run them..

1. Create a new .NET project by using the `.NET: New Project...` command and selecting `Console App`. 
1. Select the **code** folder and name the project **Skills**.
1. Open `Program.cs`
1. Verify your new file looks like:
   ![VS code with a new Program.cs](./img/2-skills-dotnet-0.png)

1. In the `Program.cs` file, remove any code and then type the following function header.

   ```csharp
   void CalculateNumbers(int var1, int var2)
   {
   ```

   GitHub Copilot will automatically suggest an entire function body in grayed text. Below is an example of what you'll most likely see, but the exact suggestion may vary.
   ![VS Code with completions](./img/2-skills-dotnet-1.png)

5. Press `Tab` to accept the suggestion.

### ⌨️ Activity: Push code to your repository from the codespace

Let's use GitHub Copilot to summarize our changes and then commit the code. 

1. Open the **Source Control** tab
2. Tap on the ✨ button in the **Message** entry for Copilot to generate your message.

![Commit tab open to generate message with Copilot](img/2-skills-commit.png)

3. Click the **Commit** button.


Head to [Part 3 of the Exercise](./3-copilot-hub.md)
