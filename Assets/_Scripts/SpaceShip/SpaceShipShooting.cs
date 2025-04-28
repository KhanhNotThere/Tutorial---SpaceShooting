using UnityEngine;

public class SpaceShipShooting : MonoBehaviour
{
    //[SerializeField] private Transform bulletPrefap;
    [SerializeField] private bool isFire = false;
    [SerializeField] private float bulletDelay = 0f;

    [SerializeField] private float bulletTimer = 1f;

    private void Update()
    {
        isFire = CheckUserMouseInput();
    }

    void FixedUpdate()
    {
        if (bulletDelay < bulletTimer)
        {
            bulletDelay += Time.fixedDeltaTime;
            return;
        }

        if (!isFire)
        {
            return;
        }

        bulletDelay = 0f;

        Shooting();
    }

    private void Shooting()
    {
        Transform bullet = BulletSpawner.Instance.Spawn(BulletSpawner.Instance.bulletOne ,transform.parent.position, transform.parent.rotation);

        if (bullet == null)
        {
            return;
        }

        bullet.gameObject.SetActive(true);
    }

    private bool CheckUserMouseInput()
    {
        isFire = (InputManager.Instance.IsFire != 0);
        return isFire;
    }
}
