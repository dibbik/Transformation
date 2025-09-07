using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float minScale = 0.5f;
    public float maxScale = 2f;
    public float scaleSpeed = 1f;

    private Vector3 _initialScale;

    private bool _isScaling = true;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    void Update()
    {
        float scaleChange = Mathf.PingPong(Time.time * scaleSpeed, scaleSpeed);
        scaleChange = Mathf.Lerp(minScale, maxScale, scaleChange);
        transform.localScale = _initialScale * scaleChange;
    }

    public void SetActive(bool active)
    {
        _isScaling = active;
    }
}
