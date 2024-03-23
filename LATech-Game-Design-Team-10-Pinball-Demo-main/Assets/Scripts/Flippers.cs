using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public Controls controls;


    // Start is called before the first frame update
    void Start()
    {
        controls = new();
        controls.Enable();
    }


    public void FlipLeft()
    {
        // add stuff here
    }

    public void FlipRight()
    {
        // add stuff here
    }

    // Update is called once per frame
    void Update()
    {
        if (controls.Testing.FlipperLeft.WasPressedThisFrame())
        {
            FlipLeft();
        }
        else if (controls.Testing.FlipperRight.WasPressedThisFrame())
        {
            FlipRight();
        }
    }
}
