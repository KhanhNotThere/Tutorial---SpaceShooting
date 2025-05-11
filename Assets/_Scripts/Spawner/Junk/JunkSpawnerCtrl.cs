using UnityEngine;

public class JunkSpawnerCtrl : KhanhBeharvier
{
    [SerializeField] private JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner { get { return junkSpawner; } }
    [SerializeField] private JunkSpawnPoints junkSpawnPoints;
    public JunkSpawnPoints JunkSpawnPoints {  get { return junkSpawnPoints; } }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadJunkSpawner();
        LoadJunkSpawnPoints();
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

    private void LoadJunkSpawnPoints()
    {
        if (junkSpawnPoints != null)
        {
            return;
        }

        junkSpawnPoints = Transform.FindObjectOfType<JunkSpawnPoints>();
        Debug.Log("JunkSpawnPoint: " +  junkSpawnPoints);
    }
}
