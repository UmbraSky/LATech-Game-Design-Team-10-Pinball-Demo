using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public Controls controls;
    public Rigidbody leftFlipperRigidbody;
    public Rigidbody leftSecondFlipperRigidbody;
    public Rigidbody rightFlipperRigidbody;

    // Adjust forces here
    public float flipperForce = 3f; 
    public float returnForce = 10f;

    void Start()
    {
        controls = new Controls();
        controls.Enable();
    }

    void Update()
    {
        if (controls.Testing.FlipperLeft.WasPressedThisFrame())
        {         
            Flip(leftFlipperRigidbody, transform.forward);
            Flip(leftSecondFlipperRigidbody, transform.forward);
        }
        else if (controls.Testing.FlipperRight.WasPressedThisFrame())
        {          
            Flip(rightFlipperRigidbody, transform.forward);       
        }
    }

    // Flip paddle, disable control, spring paddle back, enable control
    void Flip(Rigidbody flipperRigidbody, Vector3 forceDirection)
    {
        flipperRigidbody.AddForce(forceDirection * flipperForce, ForceMode.Impulse);
        controls.Disable();
        EnableSpring(flipperRigidbody.GetComponent<HingeJoint>());
    }

    void EnableSpring(HingeJoint hingeJoint)
    {
        hingeJoint.useSpring = true;
        hingeJoint.spring = new JointSpring { spring = returnForce };
        controls.Enable();
    }
}
