using UnityEngine;

public class ObjectMovement : KhanhBeharvier
{
    private Vector3 objectDir = Vector3.down;
    protected float objectSpeed = 10f;

    void Update()
    {
        BulletMove();
    }

    private void BulletMove()
    {
        transform.parent.Translate(objectDir * objectSpeed * Time.deltaTime);
    }
}
