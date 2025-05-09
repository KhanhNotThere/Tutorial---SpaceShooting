using UnityEngine;

public class FollowPlayer : KhanhBeharvier
{
    [SerializeField] private Transform player;
    [SerializeField] private float followSpeed = 1f;

    private void FixedUpdate()
    {
        Follow();
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadPlayer();
    }

    private void LoadPlayer()
    {
        if (player != null)
        {
            return;
        }

        player = GameObject.Find("SpaceShip").transform;
    }

    private void Follow()
    {
        if (player == null)
        {
            return;
        }

        transform.position = Vector3.Lerp(transform.position, player.position, followSpeed * Time.fixedDeltaTime );
    }
}
