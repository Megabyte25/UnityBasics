using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public Transform target;

    // Late update to ensure everything has moved already
    void LateUpdate()
    {
        transform.LookAt(target);
    }
}
