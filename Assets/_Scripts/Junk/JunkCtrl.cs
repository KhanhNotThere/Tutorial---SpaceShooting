using UnityEngine;

public class JunkCtrl : KhanhBeharvier
{
    [SerializeField] protected Transform junkModel;
    public Transform JunkModel { get { return junkModel; } }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadModel();
    }

    private void LoadModel()
    {
        if (junkModel != null)
        {
            return;
        }

        junkModel = transform.Find("AsterModel");
    }
}
