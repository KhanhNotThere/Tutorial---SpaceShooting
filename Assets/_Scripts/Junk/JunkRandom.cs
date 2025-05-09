using UnityEngine;

public class JunkRandom : KhanhBeharvier
{
    [SerializeField] private JunkSpawnerCtrl junkSpawnerCtrl;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkCtrl();
    }

    protected override void Start()
    {
        base.Start();
        JunkSpawn();
    }

    protected void LoadJunkCtrl()
    {
        if (junkSpawnerCtrl != null)
        {
            return;
        }

        junkSpawnerCtrl = GetComponent<JunkSpawnerCtrl>();
        Debug.Log("Junk Controler: " + junkSpawnerCtrl);
    }

    private void JunkSpawn()
    {
        Transform RandPoint = junkSpawnerCtrl.JunkSpawnPoints.GetRandomPoint();
        Transform obj = junkSpawnerCtrl.JunkSpawner.Spawn(JunkSpawner.Instance.asterOne, RandPoint.position, RandPoint.rotation);
        obj.gameObject.SetActive(true);
        Invoke(nameof(JunkSpawn), 1f);
    }
}
