using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 5f;

    void Update()
    {
        transform.Rotate(Vector3.down * _rotationSpeed * Time.deltaTime);
    }
}
