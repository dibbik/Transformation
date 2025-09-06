using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float scaleSpeed = 1f;

    void Update()
    {
        float scaleChange = scaleSpeed * Time.deltaTime;
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
