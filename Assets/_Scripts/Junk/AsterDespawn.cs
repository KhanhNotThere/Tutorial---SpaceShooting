using UnityEngine;

public class AsterDespawn : DespawnByDistance
{
    protected override void ResetValue()
    {
        base.ResetValue();
        disLimit = 35f;
    }

    public override void DespawnObject()
    {
        JunkSpawner.Instance.Despawn(transform.parent);
    }
}
