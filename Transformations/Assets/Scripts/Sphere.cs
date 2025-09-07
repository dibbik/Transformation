using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveDistance = 10f;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        float zOffset = Mathf.PingPong(Time.time * moveSpeed, moveDistance);

        transform.position = _startPosition + Vector3.forward * zOffset;
    }
}
