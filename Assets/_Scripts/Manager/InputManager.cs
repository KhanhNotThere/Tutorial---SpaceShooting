using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Vector3 targetPos = new();
    private static InputManager instance;
    public Vector3 TargetPos { get { return targetPos; }}
    public static InputManager Instance { get { return instance; }}

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("There is more than one InputManager!");
            return;
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        GetMousePos();
    }

    private void GetMousePos()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
