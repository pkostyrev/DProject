public interface IPlayer
{
    int Health { get; set; }
    int Lives { get; set; }
    string Nickname { get; set; }
    string[] Skills { get; set; }
    Equipment Equipment { get;}
}
