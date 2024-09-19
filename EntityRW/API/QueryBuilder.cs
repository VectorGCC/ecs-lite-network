using Leopotam.EcsLite;

public struct QueryBuilder
{
    private readonly EcsWorld _world;
    private EcsWorld.Mask _filerMask;

    public QueryBuilder(EcsWorld world)
    {
        _world = world;
        _filerMask = null;
    }

    public QueryBuilder With<T>() where T : struct
    {
        _filerMask = _world.Filter<T>();
        return this;
    }

    public QueryBuilder With<T1, T2>() where T1 : struct where T2 : struct
    {
        _filerMask = _world.Filter<T1>().Inc<T2>();
        return this;
    }

    public Enumerator GetEnumerator()
    {
        return new Enumerator(_filerMask.End());
    }
}