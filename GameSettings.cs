public sealed class GameSettings
{
    private static readonly Lazy<GameSettings> instance =
        new Lazy<GameSettings>(() => new GameSettings());

    private GameSettings()
    {
    }

    public static GameSettings Instance => instance.Value;

    public string Difficulty { get; set; } = "Expert";
    public int SoundVolume { get; set; } = 70;
}