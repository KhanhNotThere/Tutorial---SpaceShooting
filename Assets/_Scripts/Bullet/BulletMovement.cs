using UnityEngine;

public class BulletMovement : ObjectMovement
{
    protected override void ResetValue()
    {
        base.ResetValue();
        objectSpeed = 10f;
    }
}
