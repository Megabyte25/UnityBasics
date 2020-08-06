using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class PlayerPropertyModifier : MonoBehaviour
{
    private PlayerInput playerInput;
    private Light spotlight;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        spotlight = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // Speed up
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            playerInput.speed += 1;
        }

        // Speed down
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            playerInput.speed -= 1;
        }

        // Toggle the lights
        if(Input.GetKeyDown(KeyCode.L))
        {
            spotlight.enabled = !spotlight.enabled;
        }
    }
}
