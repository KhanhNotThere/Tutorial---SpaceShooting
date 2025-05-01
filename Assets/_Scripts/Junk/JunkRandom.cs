using UnityEngine;

public class JunkRandom : KhanhBeharvier
{
    [SerializeField] private JunkCtrl junkCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkCtrl();
    }

    private void Start()
    {
        JunkSpawn();
    }

    protected void LoadJunkCtrl()
    {
        if (junkCtrl != null)
        {
            return;
        }

        junkCtrl = GetComponent<JunkCtrl>();
        Debug.Log("Junk Controler: " + junkCtrl);
    }

    private void JunkSpawn()
    {
        Transform RandPoint = junkCtrl.JunkSpawnPoints.GetRandomPoint();
        Transform obj =  junkCtrl.JunkSpawner.Spawn(JunkSpawner.Instance.asterOne, RandPoint.position, RandPoint.rotation);
        obj.gameObject.SetActive(true);
        Invoke(nameof(JunkSpawn), 1f);
    }
}
