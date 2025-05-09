using UnityEngine;

public class JunkRotation : JunkAbstract
{
    [SerializeField] private float rotationSpeed = 7f;

    private void FixedUpdate()
    {
        Rotate();
    }

    private void Rotate()
    {
        Vector3 eulers = new Vector3(0, 0, 1);
        this.junkCtrl.JunkModel.Rotate(eulers * this.rotationSpeed * Time.fixedDeltaTime);
    }
}
