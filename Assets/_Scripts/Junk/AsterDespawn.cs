using UnityEngine;

public class AsterDespawn : DespawnByDistance
{
    protected override void ResetValue()
    {
        base.ResetValue();
        disLimit = 35f;
    }

    protected override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }

}
