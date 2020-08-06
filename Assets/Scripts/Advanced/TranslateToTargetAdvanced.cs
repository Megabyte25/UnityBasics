using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateToTargetAdvanced : MonoBehaviour
{
    public Transform target;
    public float speed;
    //public float translationSmoothing;

    public float slowDistance;
    public float arrivalDistance;
    

    void Update()
    {
        /*
         * Attempt 1: Bounces back and forth around the target
         */

        //Vector3 direction = target.position - transform.position;
        //transform.Translate(direction.normalized * speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
         /*
         * Attempt 2: Use Lerp to smoothly arrive to the target position
         * Arrives to target too slowly
         */

        //transform.position = Vector3.Lerp(transform.position, target.transform.position, translationSmoothing);
    }

    private void LateUpdate()
    {
        /*
         * Attempt 3: Move at full speed, then slow down when the target is near, then stop completely when it is close enough
         * So far, this shows the best result but requires some vector math
         */

        Vector3 direction = target.transform.position - transform.position;
        float distance = direction.magnitude;

        if (distance > slowDistance)
        {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        else if (distance > arrivalDistance)
        {
            float percentage = (distance - arrivalDistance) / (slowDistance - arrivalDistance);
            transform.Translate(direction.normalized * speed * percentage * Time.deltaTime, Space.World);
        }
    }
}
