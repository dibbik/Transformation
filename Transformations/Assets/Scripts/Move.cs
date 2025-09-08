using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _moveDistance = 10f;

    [SerializeField] private bool _isInvertMovement = false;

    private Vector3 _startPosition;

    private int _direction = 1;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (Vector3.Distance(_startPosition, transform.position) >= _moveDistance)
        {
            if (_isInvertMovement)
            {
                _direction *= -1;
                _startPosition = transform.position;
            }
        }

        transform.position += transform.forward * _direction * _moveSpeed * Time.deltaTime;
    }
}