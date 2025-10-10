using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform cameraTransform;

    void Update()
    {
        cameraTransform.LookAt(cameraTransform);
        transform.rotation = Quaternion.Euler(0, cameraTransform.rotation.eulerAngles.y, 0);
    }
}
