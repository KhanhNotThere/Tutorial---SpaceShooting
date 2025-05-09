using UnityEngine;

public class BulletAbstract : KhanhBeharvier
{
    [Header("Bullet Controller")]
    [SerializeField] protected BulletCtrl bulletCtrl;

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
}
 