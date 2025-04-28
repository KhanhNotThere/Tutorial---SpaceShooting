using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : KhanhBeharvier
{
    [SerializeField] private List<Transform> prefaps;
    [SerializeField] private Transform holderTran;
    [SerializeField] private List<Transform> poolObj;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPrefaps();
        LoadHolder();
    }

    private void LoadPrefaps()
    {
        if (prefaps.Count != 0)
        {
            return;
        }

        Transform prefapsTrans = transform.Find("Prefaps");

        foreach (Transform prefap in prefapsTrans)
        {
            prefaps.Add(prefap);
        }

        HidePrefaps();
    }

    private void LoadHolder()
    {
        holderTran = transform.Find("Holder");
        Debug.Log("Holder loaded: " + holderTran);
    }

    private void HidePrefaps()
    {
        foreach (Transform prefap in prefaps)
        {
            prefap.gameObject.SetActive(false);
        }
    }

    public Transform Spawn(string prefapName, Vector3 spawnPos,Quaternion spawnRotation)
    {
        Transform prefap = GetPrefapByName(prefapName);

        if (prefap == null)
        {
            Debug.LogWarning("Prefap not found");
            return null;
        }

        Transform newPrefap = GetObjectFromPool(prefap);
        newPrefap.SetPositionAndRotation(spawnPos, spawnRotation);
        newPrefap.parent = holderTran;

        return newPrefap;
    }

    private Transform GetPrefapByName(string prefapName)
    {
        foreach(Transform prefap in prefaps)
        {
            if (prefap.name == prefapName)
            {
                return prefap;
            }
        }

        return null;
    }

    private Transform GetObjectFromPool(Transform transform)
    {
        foreach (Transform prefap in poolObj)
        {
            if (prefap.name == transform.name)
            {
                poolObj.Remove(prefap);
                return prefap;
            }
        }

        Transform newPrefap = Instantiate(transform);
        newPrefap.name = transform.name;
        return newPrefap;
    }

    public void Despawn(Transform transform)
    {
        poolObj.Add(transform);
        transform.gameObject.SetActive(false);
    }
}
