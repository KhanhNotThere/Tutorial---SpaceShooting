using UnityEngine;

public class JunkDamageReceiver : DamageReceiver
{
    [SerializeField] private JunkCtrl junkCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkCtrl();
    }

    private void LoadJunkCtrl()
    {
        if (junkCtrl != null)
        {
            return;
        }

        junkCtrl = transform.parent.GetComponent<JunkCtrl>();
    }

    protected override void OnDead()
    {
        junkCtrl.AsterDespawn.DespawnObject();
    }
}
