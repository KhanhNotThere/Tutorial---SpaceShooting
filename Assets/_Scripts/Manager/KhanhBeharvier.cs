using Unity.VisualScripting;
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

    protected virtual void Start()
    {

    }

    protected virtual void ResetValue()
    {

    }

    protected virtual void OnEnable()
    {

    }

    protected virtual void OnDisable ()
    {

    }
}
