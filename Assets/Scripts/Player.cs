public class Player : IPlayer
{
    public int Health { get; set; }
    public int Lives { get; set; }
    public string Nickname { get; set; }
    public string[] Skills { get; set; }
    public Equipment Equipment { get;}

    public Player(Equipment equipment)
    {
        Equipment = equipment;
    }
}
