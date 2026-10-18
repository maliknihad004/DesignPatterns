public sealed class PlayerProfile
{
    public string Username { get; private set; }
    public string ClassType { get; private set; }
    public int Level { get; private set; }
    public List<string> Inventory { get; private set; }

    private PlayerProfile()
    {
        Username = "Player";
        ClassType = "Warrior";
        Level = 1;
        Inventory = new List<string>();
    }

    public class Builder
    {
        private PlayerProfile player = new PlayerProfile();

        public Builder SetUsername(string username)
        {
            player.Username = username;
            return this;
        }

        public Builder SetClassType(string classType)
        {
            player.ClassType = classType;
            return this;
        }

        public Builder SetLevel(int level)
        {
            player.Level = level;
            return this;
        }

        public Builder AddItem(string item)
        {
            player.Inventory.Add(item);
            return this;
        }

        public PlayerProfile Build()
        {
            PlayerProfile result = player;
            player = new PlayerProfile();
            return result;
        }
    }
}