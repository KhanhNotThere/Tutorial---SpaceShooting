using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
[RequireComponent (typeof(Rigidbody))]
public class BulletImpact : BulletAbstract
{
    [Header("Bullet Impact")]
    [SerializeField] private SphereCollider sphereCollider;
    [SerializeField] private Rigidbody _rigidbody;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadSphereCollider();
        LoadRigidbody();
    }

    private void LoadSphereCollider()
    {
        if (sphereCollider != null)
        {
            return;
        }

        sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;
        sphereCollider.radius = 0.04f;
        Debug.Log("SphereCollider: " + sphereCollider);
    }

    private void LoadRigidbody()
    {
        if (_rigidbody != null)
        {
            return;
        }

        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.isKinematic = true;
        Debug.Log("Rigidbody: " + _rigidbody);
    }

    private void OnTriggerEnter(Collider other)
    {
        bulletCtrl.DamageSender.Send(other.transform);
    }
}
