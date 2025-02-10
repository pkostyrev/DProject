using Zenject;

public class Installer : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IPlayer>().To<Player>().AsSingle();
        Container.Bind<Equipment>().AsSingle();
    }
}