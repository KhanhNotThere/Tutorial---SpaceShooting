using UnityEngine;

public class DespawnByTime : Despawn
{
    protected override bool CanDespawn()
    {
        return false;
    }
}
