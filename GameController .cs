using Zenject;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private IPlayer _player;

    [Inject]
    public void Construct(IPlayer player)
    {
        _player = player;
    }

    void Start()
    {
        // Инициализация игрока
        _player.Health = 100;
        _player.Lives = 3;
        _player.Nickname = "John";
        _player.Skills = new string[] { "Skill1", "Skill2", "Skill3" };

        Debug.Log("Здоровье игрока: " + _player.Health);
        Debug.Log("Никнейм игрока: " + _player.Nickname);

        // Добавление экипировки
        _player.Equipment.AddItem(new Weapon("Винтовка", 50));
        _player.Equipment.AddItem(new Parachute());
        _player.Equipment.AddItem(new RocketPack(3)); // Ракетный ранец с 3 зарядами
    }
}