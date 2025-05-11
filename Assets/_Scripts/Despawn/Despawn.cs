using UnityEngine;

public abstract class Despawn : KhanhBeharvier
{
    private void FixedUpdate()
    {
        Despawning();
    }
    private void Despawning()
    {
        if (CanDespawn())
        {
            DespawnObject();
        }
    }

    public virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    protected abstract bool CanDespawn();
}
