using UnityEngine;

public class SpaceShipShooting : MonoBehaviour
{
    [SerializeField] private Transform bulletPrefap;
    [SerializeField] private bool isFire = false;

    void FixedUpdate()
    {
        if (!isFire)
        {
            return;
        }

        Shooting();
    }

    private void Shooting()
    {
        Transform bullet = Instantiate(bulletPrefap,transform.parent.position, transform.parent.rotation);
    }
}
