using UnityEngine;

public class BulletDamageSender : DamageSender
{
    [SerializeField] private BulletCtrl bulletCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadBulletCtrl();
    }

    private void LoadBulletCtrl()
    {
        if (bulletCtrl != null)
        {
            return;
        }

        bulletCtrl = transform.parent.GetComponent<BulletCtrl>();
    }

    public override void Send(DamageReceiver damageReceiver)
    {
        base.Send(damageReceiver);
        DestroyBullet();
    }

    private void DestroyBullet()
    {
        bulletCtrl.BulletDespawn.DespawnObject();
    }
}
