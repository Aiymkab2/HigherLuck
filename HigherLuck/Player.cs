
namespace HigherLuck
{
    public class Player
    {
        public string Name { get; set; }
        public int AvatarIndex { get; set; }
        public int Points { get; set; }

        public Player(string name, int avatarIndex)
        {
            Name = name.ToUpper();
            AvatarIndex = avatarIndex;
            Points = 0;
        }

        public void AddPoint()
        {
            Points++;
        }
    }
}
