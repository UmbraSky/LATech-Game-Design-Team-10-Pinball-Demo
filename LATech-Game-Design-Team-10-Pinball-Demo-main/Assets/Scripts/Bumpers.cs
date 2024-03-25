using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
    /// private fields
    private Renderer render;
    Color lerpedColor;
    Color defaultColor = Color.green;
    // private bool bumped;

    // Life Cycle methods
    private void Start() {
        render = GetComponent<Renderer>();
        // bumped = false;
    }
    private void Update() {
        // if (bumped == false) {
        lerpedColor = Color.Lerp(Color.black, Color.red, Mathf.PingPong(Time.time, 1.5f));
        render.material.color = lerpedColor;
        // }
        // else if (bumped == true) {
        //     render.material.color = defaultColor;
        // }
    }
    

    // Other methods
    public void Bump() {
        // if (bumped == false){
        // bumped = true;
        print("Bump!");
        // }
    }

    // public void resetBump() {
    //     bumped = false;
    //     print("Not bumped.");
    // }
}