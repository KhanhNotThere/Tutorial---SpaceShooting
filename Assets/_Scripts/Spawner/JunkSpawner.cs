using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance {  get { return instance; } }
    public string asterOne = "Aster_1";

    protected override void Awake()
    {
        base.Awake();
        if (instance != null)
        {
            Debug.LogWarning("There is more than 1 JunkSpawner");
            return;
        }
        instance = this;
    }
}
