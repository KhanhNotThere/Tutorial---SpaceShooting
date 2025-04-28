using UnityEngine;

public class BulletSpawner : Spawner
{
    private static BulletSpawner instance;
    public static BulletSpawner Instance {  get { return instance; } }
    public string bulletOne = "Bullet_1";

    protected override void Awake()
    {
        base.Awake();
        if (instance != null)
        {
            Debug.LogWarning("There is more than one BulletSpawner!");
            return;
        }
        instance = this;
    }
}
