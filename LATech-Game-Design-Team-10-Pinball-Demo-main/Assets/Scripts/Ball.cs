using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{ public Controls controls;
    // Start is called before the first frame update
    void Start()
    {
        controls = new();
        controls.Enable();
    }

    public void Launch()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controls.Testing.BallShooter.WasReleasedThisFrame()){
            // something
        }
    }
}
