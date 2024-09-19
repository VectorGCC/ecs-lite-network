using Mirror;
using UnityEngine;

[RequireComponent(typeof(NetworkIdentity))]
public abstract class EntityViewBase : NetworkBehaviour
{
    protected EntityRW _entity;
    protected uint _lastVersion;

    [Server]
    public void Init(EntityRW entity)
    {
        _entity = entity;
    }

    protected virtual T Read<T>() where T : struct
    {
        // Override from code generation.
        return default;
    }

    protected virtual void ApplyState()
    {
    }
}