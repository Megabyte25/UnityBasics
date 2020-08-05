using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float angularSpeed;
    public Vector3 rotationAxis;

    void Update()
    {
        transform.Rotate(rotationAxis, angularSpeed * Time.deltaTime);
    }
}
