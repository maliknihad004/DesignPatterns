Console.WriteLine("=== Singleton Pattern ===");

GameSettings settings1 = GameSettings.Instance;
GameSettings settings2 = GameSettings.Instance;

Console.WriteLine($"Same Instance: {ReferenceEquals(settings1, settings2)}");

settings1.Difficulty = "Hard";
settings1.SoundVolume = 80;

Console.WriteLine($"Difficulty: {settings2.Difficulty}");
Console.WriteLine($"Sound Volume: {settings2.SoundVolume}");


Console.WriteLine("\n=== Builder Pattern ===");

PlayerProfile basicPlayer = new PlayerProfile.Builder()
    .SetUsername("Player")
    .SetClassType("Class")
    .SetLevel(1)
    .AddItem("ITEM")
    .Build();

PlayerProfile customPlayer = new PlayerProfile.Builder()
    .SetUsername("Malik")
    .SetClassType("Archer")
    .SetLevel(50)
    .AddItem("bow")
    .Build();


Console.WriteLine("\nBasic Player:");
DisplayPlayer(basicPlayer);

Console.WriteLine("\nCustom Player:");
DisplayPlayer(customPlayer);


static void DisplayPlayer(PlayerProfile player)
{
    Console.WriteLine($"Username: {player.Username}");
    Console.WriteLine($"Class: {player.ClassType}");
    Console.WriteLine($"Level: {player.Level}");

    Console.WriteLine(
        $"Inventory: {(player.Inventory.Count == 0 ? "Empty" : string.Join(", ", player.Inventory))}"
    );
}