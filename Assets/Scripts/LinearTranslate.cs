using UnityEngine;

public class LinearTranslate : MonoBehaviour
{
    public float speed = 3; // Default value 3
    public Vector3 direction;

    void Update()
    {
        // Normalized vector (max length 1) multiplied by the speed.
        // The vector is also multiplied by the delta time
        // to make this translation dependent of time instead of frame rate.
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
}
