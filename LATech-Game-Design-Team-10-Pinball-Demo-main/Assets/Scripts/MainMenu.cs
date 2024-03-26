using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainMenu : MonoBehaviour
{
    public Canvas mainMenuCanvas; 
    public InputAction controls;
    private bool controlsEnabled = false;

    // Start is called before the first frame update
    void Start()
    {
        controls.Disable();
        mainMenuCanvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Feed start button
        /*
        if (controls.ReadValue<float>("StartButton") > 0 && !controlsEnabled)
        {
            controls.Enable();
            controlsEnabled = true;
            mainMenuCanvas.enabled = false;
        }
        */
    }
}
