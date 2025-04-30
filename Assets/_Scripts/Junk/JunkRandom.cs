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
        Vector3 junkPos = transform.position;
        Quaternion junkRotation = transform.rotation;
        Transform obj =  junkCtrl.JunkSpawner.Spawn(JunkSpawner.Instance.asterOne, junkPos, junkRotation);
        obj.gameObject.SetActive(true);
        Invoke(nameof(JunkSpawn), 1f);
    }
}
