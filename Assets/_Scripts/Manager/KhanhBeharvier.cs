using UnityEngine;

public abstract class KhanhBeharvier : MonoBehaviour
{
    protected virtual void Reset()
    {
        LoadComponents();
        ResetValue();
    }

    protected virtual void Awake()
    {
        LoadComponents();
        ResetValue();
    }

    protected virtual void LoadComponents()
    {

    }

    protected virtual void ResetValue()
    {

    }
}
