using UnityEngine;

public class BulletCtrl : KhanhBeharvier
{
    [SerializeField] private DamageSender damageSender;
    public DamageSender DamageSender { get { return damageSender; } }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadDamageSender();
    }

    private void LoadDamageSender() 
    {
        if (damageSender != null)
        {
            return;
        }

        damageSender = transform.GetComponentInChildren<DamageSender>();
    }
}
