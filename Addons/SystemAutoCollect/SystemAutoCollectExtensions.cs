using Leopotam.EcsLite;

public static class SystemAutoCollectExtensions
{
    public static EcsSystems AddAutoCollectSystems(this EcsSystems systems)
    {
        var autoEcsSystems = new SystemAutoCollect();
        autoEcsSystems.AddAutoCollectSystems(systems);
        return systems;
    }
}