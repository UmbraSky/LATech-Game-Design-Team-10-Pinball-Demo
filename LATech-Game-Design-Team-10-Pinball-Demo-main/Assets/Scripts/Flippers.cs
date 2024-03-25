using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour
{
    public Controls controls;
    public float flipperForce = 100f; 
    private HingeJoint hingeJoint;

    // Start is called before the first frame update
    void Start()
    {
        controls = new Controls();
        controls.Enable();
        hingeJoint = GetComponent<HingeJoint>();
    }

    public void FlipLeft()
    {       
        JointSpring spring = hingeJoint.spring;
        spring.targetPosition = -45f; 
        hingeJoint.spring = spring;
    }

    public void FlipRight()
    {
        JointSpring spring = hingeJoint.spring;
        spring.targetPosition = 45f; 
        hingeJoint.spring = spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (controls.Testing.FlipperLeft.WasPressedThisFrame())
        {
            Debug.Log("Left flipper pressed");
            FlipLeft();
        }
        else if (controls.Testing.FlipperRight.WasPressedThisFrame())
        {
            Debug.Log("Right flipper pressed");
            FlipRight();
        }
    }
}
