using UnityEngine;

public class AsterMovement : ObjectMovement
{
    protected override void ResetValue()
    {
        base.ResetValue();
        objectSpeed = 1f;
    }
}
