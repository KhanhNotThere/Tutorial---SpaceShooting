using UnityEngine;

public class BulletCtrl : KhanhBeharvier
{
    [SerializeField] private DamageSender damageSender;
    public DamageSender DamageSender { get { return damageSender; } }

    [SerializeField] private BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn { get { return bulletDespawn; } }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadDamageSender();
        LoadBulletDespawn();
    }

    private void LoadDamageSender() 
    {
        if (damageSender != null)
        {
            return;
        }

        damageSender = transform.GetComponentInChildren<DamageSender>();
    }

    private void LoadBulletDespawn()
    {
        if (bulletDespawn != null)
        {
            return;
        }

        bulletDespawn = transform.GetComponentInChildren<BulletDespawn>();
    }
}
