using UnityEngine;

public class AsterMovement : ObjectMovement
{
    [SerializeField] protected float minCamPos = -16f;
    [SerializeField] protected float maxCamPos = 16f;

    protected override void ResetValue()
    {
        base.ResetValue();
        objectSpeed = 1f;
    }

    protected override void OnEnable()
    {
        base.OnEnable();
        GetFlyDirection();
    }

    protected void GetFlyDirection()
    {
        Vector3 camPos = GameCtrl.Instance.MainCamera.transform.position;
        Vector3 objPos = transform.parent.position;

        camPos.x += Random.Range(this.minCamPos, this.maxCamPos);
        camPos.z += Random.Range(this.minCamPos, this.maxCamPos);

        Vector3 diff = camPos - objPos;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, rot_z);

        //this.direction = (pos - transform.position).normalized;
        Debug.DrawLine(objPos, objPos + diff * 7, Color.red, Mathf.Infinity);
    }
}
