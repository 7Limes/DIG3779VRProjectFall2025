using UnityEngine;

public class TeleportBox : MonoBehaviour
{
    public Transform teleportPoint;
    public bool relative = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {   
            if (relative)
            {
                Vector3 relativeVector = other.transform.position - transform.position;
                Vector3 newPosition = teleportPoint.position + relativeVector;
                newPosition.y = teleportPoint.position.y;
                other.transform.position = newPosition;
            }
            else
            {
                other.transform.position = teleportPoint.position;
            }
        }
    }
}
