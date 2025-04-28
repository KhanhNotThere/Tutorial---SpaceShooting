using UnityEngine;

public abstract class KhanhBeharvier : MonoBehaviour
{
    protected virtual void Reset()
    {
        LoadComponents();
    }

    protected virtual void Awake()
    {
        LoadComponents();
    }

    protected virtual void LoadComponents()
    {

    }
}
