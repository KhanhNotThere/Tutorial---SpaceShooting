using UnityEngine;

public class DamageReceiver : KhanhBeharvier
{
    [SerializeField] protected float hp = 1f;
    [SerializeField] protected float hpMax = 1f;

    protected override void Start()
    {
        base.Start();
        Reborn();
    }

    private void Reborn()
    {
        hp = hpMax;
    }

    private void Add(float add)
    {
        hp += add;

        if (hp > hpMax)
        {
            hp = hpMax;
        }
    }

    public void Deduct(float deduct)
    {
        hp -= deduct;

        if (hp < 0)
        {
            hp = 0;
        }
    }

    private bool IsDead()
    {
        return hp <= 0;
    }
}
