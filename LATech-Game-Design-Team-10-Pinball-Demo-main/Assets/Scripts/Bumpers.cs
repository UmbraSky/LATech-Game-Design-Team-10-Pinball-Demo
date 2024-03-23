using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
    /// private fields
    private Renderer render;
    private float t;

    // Life Cycle methods
    private void Start() {
        render = GetComponent<Renderer>();
        t = 0;
    }
    private void Update() {
        if (t > 0) {
            Color color = Color.Lerp(Color.black, Color.red, t);
            render.material.SetColor("_BaseColor", color);
            t -= Time.deltaTime / 2.0f;
            if (t < 0) {
                t = 0;
            }
        }
    }

    // Other methods
    public void Bump() {
        print("Bump!");
        render.material.SetColor("_BaseColor", Color.red);
        t = 1;
    }
}
