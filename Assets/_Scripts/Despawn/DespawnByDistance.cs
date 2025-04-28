using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] private float disLimit = 70.0f;
    [SerializeField] private float distance = 0f;
    [SerializeField] private Transform mainCamera;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadCamera();
    }

    private void LoadCamera()
    {
        if (mainCamera != null) return;

        mainCamera = GameObject.Find("Main Camera").transform;
    }

    protected override bool CanDespawn()
    {
        distance = Vector3.Distance(mainCamera.position, transform.parent.position);
        if (distance > disLimit)
        {
            return true;
        }

        return false;
    }
}
