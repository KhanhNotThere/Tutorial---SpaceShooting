using UnityEngine;

public class JunkAbstract : KhanhBeharvier
{
    [SerializeField] protected JunkCtrl junkCtrl;
    public JunkCtrl JunkCtrl { get { return junkCtrl; } }

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
}
