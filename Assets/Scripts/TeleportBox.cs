using UnityEngine;

public class TeleportBox : MonoBehaviour
{
    public Transform teleportPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.root.position = teleportPoint.position;
        }
    }
}
