using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class DamageReceiver : KhanhBeharvier
{
    [SerializeField] private SphereCollider sphereCollider;
    [SerializeField] protected int hp = 1;
    [SerializeField] protected int hpMax = 1;
    [SerializeField] private bool isDead = false;

    protected override void OnEnable()
    {
        base.OnEnable();
        Reborn();
    }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSphereCollider();
    }

    private void LoadSphereCollider()
    {
        if (sphereCollider != null)
        {
            return;
        }

        sphereCollider = GetComponent<SphereCollider>();
    }

    private void Reborn()
    {
        hp = hpMax;
        isDead = false;
    }

    private void Add(int add)
    {
        if (isDead)
        {
            return;
        }

        hp += add;

        if (hp > hpMax)
        {
            hp = hpMax;
        }
    }

    public void Deduct(int deduct)
    {
        if (isDead)
        {
            return;
        }

        hp -= deduct;

        if (hp < 0)
        {
            hp = 0;
        }

        CheckIsDead();
    }

    private bool IsDead()
    {
        return hp <= 0;
    }

    protected void CheckIsDead()
    {
        if (!IsDead())
        {
            return;
        }

        isDead = true;
        OnDead();
    }

    protected virtual void OnDead()
    {
        //For overrides
    }
}
