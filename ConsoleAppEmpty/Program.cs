using gameEnums;

public class Program
{
    static void Main(string[] args)
    {
        GameClass gameClass = GameClass.Warrior;
        GameDifficulty gameDifficulty = GameDifficulty.Easy;


        Console.WriteLine($@"Select a difficulty(1.{GameDifficulty.Easy}, 2.{GameDifficulty.Medium}, 3.{GameDifficulty.Hard}): ");

        int inputDifficulty = int.Parse(Console.ReadLine());

        if (inputDifficulty == 1) 
        {
            gameDifficulty = GameDifficulty.Easy;
        }
        else if (inputDifficulty == 2) 
        {
            gameDifficulty = GameDifficulty.Medium;
        }
        else if (inputDifficulty == 3) 
        {
            gameDifficulty = GameDifficulty.Hard;
        }
        
        Console.WriteLine($@"Select a difficulty(1.{GameClass.Warrior}, 2.{GameClass.Mage}, 3.{GameClass.Rogue}): ");

        int inputClass = int.Parse(Console.ReadLine());

        if (inputClass == 1) 
        {
            gameClass = GameClass.Warrior;
        }
        else if (inputClass == 2) 
        {
            gameClass = GameClass.Mage;
        }
        else if (inputClass == 3) 
        {
            gameClass = GameClass.Rogue;
        }


        Console.WriteLine($@"
You selected:
Difficulty: {gameDifficulty}
Character Class: {gameClass}
");
    }
}