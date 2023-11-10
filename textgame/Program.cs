
public class Play
{

    public static void Main(string[] args)
    {
        new Play().PlayGame();
    }

    public void PlayGame()
    {
        var story = new Story();
        var scenes = story.GetScenes();
        var sceneId = 0;
        while (sceneId >= 0)
        {
            var scene = scenes[sceneId];
            sceneId = RunScene(scene);
        }

        Console.WriteLine("...see you again... real soon...");
    }

    public int RunScene(Scene scene)
    {
        Console.WriteLine(scene.Description);
        var nextSceneId = GetInput(scene.Options);
        return nextSceneId;
    }

    public int GetInput(SceneOption[] options)
    {
        int[] validOptions = new int[options.Length + 1];
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i].Description}");
            validOptions[i] = i + 1;
        }
        Console.WriteLine("What do you do?");
        Console.WriteLine("press the number corisponding to your choice, then press enter.");
        Console.WriteLine("-10 to exit game");

        var isValid = false;
        int input = 0;
        while (!isValid)
        {
            string? inputText = Console.ReadLine();
            if (int.TryParse(inputText, out int inputInt))
            {
                input = inputInt;
                isValid = input < 0 || validOptions.Contains(input);
            }

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        var optionIndex = Convert.ToInt32(input) - 1;
        return options[optionIndex].NextSceneId;
    }
}