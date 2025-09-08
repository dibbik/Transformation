using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _minScale = 0.5f;
    [SerializeField] private float _maxScale = 2f;
    [SerializeField] private float _scaleSpeed = 1f;

    private Vector3 _initialScale;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    void Update()
    {
        float scaleChange = Mathf.PingPong(Time.time * _scaleSpeed, _scaleSpeed);

        scaleChange = Mathf.Lerp(_minScale, _maxScale, scaleChange);
        transform.localScale = _initialScale * scaleChange;
    }
}
