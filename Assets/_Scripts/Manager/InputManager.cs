using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Vector3 targetPos = new();
    private float isFire = 0;
    private static InputManager instance;
    public Vector3 TargetPos { get { return targetPos; }}
    public float IsFire { get { return isFire; }}
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
        GetMouseClick();
    }

    private void GetMouseClick()
    {
        isFire = Input.GetAxis("Fire1");
    }

    private void GetMousePos()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
