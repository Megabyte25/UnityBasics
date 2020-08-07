using UnityEngine;

public class CarInput : MonoBehaviour
{
    LinearTranslate linearTranslator;
    Rotate rotator;

    void Start()
    {
        linearTranslator = GetComponent<LinearTranslate>();
        rotator = GetComponent<Rotate>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Kind of silly, but interesting to try!
        // It's best for each component to define a function like "ReceiveInput()"
        // and let them decide how to move the object.
        linearTranslator.speed = vertical * 5f;
        rotator.angularSpeed = horizontal * 180f;
    }
}
