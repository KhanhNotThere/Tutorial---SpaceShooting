using UnityEngine;

public class GameCtrl : KhanhBeharvier
{
    private static GameCtrl instance;
    public static GameCtrl Instance { get { return instance; } }

    [SerializeField] private Transform mainCamera;
    public Transform MainCamera { get { return mainCamera; } }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadCamera();
    }

    private void LoadCamera()
    {
        if (mainCamera != null) return;

        mainCamera = GameObject.Find("Main Camera").transform;
    }

    protected override void Awake()
    {
        base.Awake();
        if (instance != null)
        {
            return;
        }
        instance = this;
    }
}
