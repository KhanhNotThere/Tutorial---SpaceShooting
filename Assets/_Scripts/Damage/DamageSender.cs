using UnityEngine;

public class DamageSender : KhanhBeharvier
{
    [SerializeField] private float damage = 1f;

    public void Send(Transform transform)
    {
        DamageReceiver damageReceiver = transform.GetComponentInChildren<DamageReceiver>();

        if (damageReceiver == null )
        {
            return;
        }

        Send(damageReceiver);
    }

    public void Send(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(damage);
        Debug.Log("Take:" + damage + " damage.");   
        DestroyObj();
    }

    private void DestroyObj()
    {
        Destroy(transform.parent.gameObject);
    }
}
