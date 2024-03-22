using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour


{ public Controls controls;
    public float launchForce;
    public Ball ball;
    private Rigidbody rb;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controls = new();
        controls.Enable();
    }

    public void Shooter()
    {
        float actualLaunchForce = Random.Range(launchForce * 0.8f, launchForce * 1.2f);
        rb.AddForce(Vector3.forward * actualLaunchForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (controls.Testing.BallShooter.WasReleasedThisFrame()){
            print("ball");
            Shooter();
        }
    }
}