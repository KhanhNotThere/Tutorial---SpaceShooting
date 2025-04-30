using UnityEngine;

public class JunkCtrl : KhanhBeharvier
{
    [SerializeField] private JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner { get { return junkSpawner; } }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkSpawner();
    }

    private void LoadJunkSpawner()
    {
        if (junkSpawner != null)
        {
            return;
        }

        junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log("JunkSpawn: " +  junkSpawner);
    }
}
