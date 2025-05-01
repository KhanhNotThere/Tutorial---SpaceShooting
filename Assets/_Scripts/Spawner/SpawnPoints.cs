using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnPoints : KhanhBeharvier
{
    [SerializeField] private List<Transform> spawnPoints;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPoints();
    }

    private void LoadPoints()
    {
        if (spawnPoints.Count != 0)
        {
            return;
        }

        foreach (Transform point in transform)
        {
            spawnPoints.Add(point);
        }
    }

    public Transform GetRandomPoint()
    {
        int randomInt = Random.Range(0, spawnPoints.Count);
        return spawnPoints[randomInt];
    }
}
