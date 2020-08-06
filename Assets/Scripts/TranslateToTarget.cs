using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateToTarget : MonoBehaviour
{
    public Transform target;
    public float speed;

    void Update()
    {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
