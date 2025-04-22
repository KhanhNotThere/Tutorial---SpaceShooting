using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    [SerializeField] private float shipSpeed = 10.0f;
    [SerializeField] private Vector3 targetPos = new();

    void Update()
    {
        GetTargetPos();
        ResetZAxis();
        Move();
    }

    private void GetTargetPos()
    {
        targetPos = InputManager.Instance.TargetPos;
    }

    private void ResetZAxis()
    {
        targetPos.z = 0;
    }

    private void Move()
    {
        Vector3 moveVec = Vector3.Lerp(transform.parent.position, targetPos, shipSpeed * Time.deltaTime);
        transform.parent.position = moveVec;
    }
}
