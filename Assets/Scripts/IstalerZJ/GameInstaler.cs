
using Zenject;

public class GameInstaler : MonoInstaller
{ 
    public override void InstallBindings()
    {
        Container.Bind<IMassages>().To<CubeMassage>().AsSingle();
        Container.Bind<ShowMassage>().AsSingle().NonLazy();
    }
}
    

