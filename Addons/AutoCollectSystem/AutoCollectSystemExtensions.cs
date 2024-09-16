using Leopotam.EcsLite;

public static class AutoCollectSystemExtensions
{
    public static EcsSystems AddAutoCollectSystems(this EcsSystems systems)
    {
        var autoEcsSystems = new AutoCollectSystem();
        autoEcsSystems.AddAutoCollectSystems(systems);
        return systems;
    }
}