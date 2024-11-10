using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    public float followDistance = 1;
    private Vector3 velocity = Vector3.zero;
    private Bounds _cameraBounds;
    private Vector3 _targetPosition;
    private Camera _mainCamera;

    private void Awake() => _mainCamera = Camera.main;

    private void Start()
    {
        var height = _mainCamera.orthographicSize;
        var width = height * _mainCamera.aspect;

        var minX = Globals.WorldBounds.min.x + width;
        var minY = Globals.WorldBounds.min.y + height;
        var maxX = Globals.WorldBounds.extents.x - width;
        var maxY = Globals.WorldBounds.extents.y - height;

        _cameraBounds = new Bounds();
        _cameraBounds.SetMinMax(
            new Vector3(minX, minY, 0.0f),
            new Vector3(maxX, maxY, 0.0f)
        );
    }
    void Update()
    {
        // Define a target position above and behind the target transform
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, followDistance, -10));
        
        _targetPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        _targetPosition = GetCameraBounds();
        // Smoothly move the camera towards that target position
        transform.position = _targetPosition;
    }

    private Vector3 GetCameraBounds()
    {
        return new Vector3(
            Mathf.Clamp(_targetPosition.x, _cameraBounds.min.x, _cameraBounds.max.x),
            Mathf.Clamp(_targetPosition.y, _cameraBounds.min.y, _cameraBounds.max.y),
            transform.position.z
        );
    }
}
