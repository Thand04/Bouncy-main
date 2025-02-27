using UnityEngine;

public class Portal : MonoBehaviour
{

    [SerializeField] private Portal portalToTeleportTo;
    [SerializeField] private Vector3 teleportPosition;
    [SerializeField] private float timeBeforeteleport;
    [HideInInspector] private bool canTeleport = true;

    private void OnCollisionEnter(Collision collision)
    {
        if (canTeleport == false) return;
        if (portalToTeleportTo.canTeleport == false) return;
        if (collision.gameObject.TryGetComponent<BallController>(out BallController ball))
        {
            ball.transform.position = teleportPosition;
            canTeleport = false;
        }
        
    }

    private void OnCollisionExit(Collision collision)
    {
        canTeleport = true;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
