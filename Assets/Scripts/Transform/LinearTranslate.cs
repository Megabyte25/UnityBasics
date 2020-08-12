using UnityEngine;
using UnityEngine.XR.WSA;

public class LinearTranslate : MonoBehaviour
{
    public float speed;
    public Vector3 direction;

    void Update()
    {
        /*
         * Attempt 1: Translate using direction only.
         * Results are terrible! Large vector magnitude makes the object move too fast.
         */

        //transform.Translate(direction);

        /*
         * Attempt 2: Translate with (normalized direction * speed). Looks good, but dependent on frame rate.
         */

        //transform.Translate(direction.normalized * speed);

        /*
         * Attempt 3: Normalized vector multiplied by speed and delta time.
         * Object moves at desired speed and is dependent on time instead of frame rate.
         */

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.Self);
    }
}
