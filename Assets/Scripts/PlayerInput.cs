using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Legacy input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        direction = Vector3.ClampMagnitude(direction, 1f);
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void SayHello()
    {
        Debug.Log("Hello World!");
    }
}
