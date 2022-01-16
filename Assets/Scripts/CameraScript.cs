using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    void FixedUpdate()
    {
        if (playerTransform != null)
        transform.position = new Vector3(playerTransform.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
