using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;
    public float angularSpeed;

    // When your object's transform depends on another's object,
    // use LateUpdate to ensure the other object already finished moving!
    private void LateUpdate()
    {
        // Set transform.rotation with desired rotation
        Vector3 direction = target.position - transform.position;
        Quaternion desiredRotation = Quaternion.LookRotation(direction, transform.up);
        transform.rotation = desiredRotation;

    }
}
