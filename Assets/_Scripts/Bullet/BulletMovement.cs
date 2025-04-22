using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Vector3 bulletDir = Vector3.down;
    private float bulletSpeed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        BulletMove();
    }

    private void BulletMove()
    {
        transform.parent.Translate(bulletDir * bulletSpeed * Time.deltaTime);
    }
}
