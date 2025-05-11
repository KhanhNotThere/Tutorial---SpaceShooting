using UnityEngine;

public class JunkCtrl : KhanhBeharvier
{
    [SerializeField] protected Transform junkModel;
    public Transform JunkModel { get { return junkModel; } }
    [SerializeField] protected AsterDespawn asterDespawn;
    public AsterDespawn AsterDespawn {  get { return asterDespawn; } }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadModel();
        LoadAsterDespawn();
    }

    private void LoadModel()
    {
        if (junkModel != null)
        {
            return;
        }

        junkModel = transform.Find("AsterModel");
    }

    private void LoadAsterDespawn()
    {
        if (asterDespawn != null)
        {
            return;
        }

        asterDespawn = GetComponentInChildren<AsterDespawn>();
    }
}
