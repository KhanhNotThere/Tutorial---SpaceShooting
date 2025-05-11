using UnityEngine;

public class DamageSender : KhanhBeharvier
{
    [SerializeField] private int damage = 1;

    public void Send(Transform transform)
    {
        DamageReceiver damageReceiver = transform.GetComponentInChildren<DamageReceiver>();

        if (damageReceiver == null )
        {
            return;
        }

        Send(damageReceiver);
    }

    public virtual void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(damage);
        Debug.Log("Take:" + damage + " damage.");   
    }
}
