using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        // A potential solution
        //Vector3 direction = target.position - transform.position;
        //Quaternion desiredRotation = Quaternion.LookRotation(direction, transform.up);
        //transform.rotation = desiredRotation;

        // Shorter solution for this use case
        transform.LookAt(target);
    }
}
