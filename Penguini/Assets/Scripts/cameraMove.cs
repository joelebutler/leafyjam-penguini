using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    public float followDistance = 1;
    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, followDistance, -10));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
