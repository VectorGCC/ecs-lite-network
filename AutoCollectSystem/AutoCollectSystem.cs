using System;
using Leopotam.EcsLite;

public class AutoCollectSystemAttribute : Attribute
{
}

public class AutoCollectSystemBase
{
    public virtual EcsSystems AddAutoCollectSystems(EcsSystems systems)
    {
        return systems;
    }
}

public partial class AutoCollectSystem : AutoCollectSystemBase
{
}

public static class AutoCollectSystemExtensions
{
    public static EcsSystems AddAutoCollectSystems(this EcsSystems systems)
    {
        return new AutoCollectSystem().AddAutoCollectSystems(systems);
    }
}