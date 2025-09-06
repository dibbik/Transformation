using UnityEngine;

[RequireComponent(typeof(Sphere))]
[RequireComponent(typeof(CubeRotation))]
[RequireComponent(typeof(Capsule))]
public class CubeComplexBehavior : MonoBehaviour
{

    void Start()
    {
        GetComponent<Sphere>().moveSpeed = 3f;
        GetComponent<CubeRotation>().rotationSpeed = 45f;
        GetComponent<Capsule>().scaleSpeed = 0.1f;

    }
}
