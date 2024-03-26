using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
    [SerializeField] ParticleSystem BumpParticles = null;
    /// private fields
    private Renderer render;
    Color lerpedColor;

    // Life Cycle methods
    private void Start() {
        render = GetComponent<Renderer>();
    }
    private void Update() {
        lerpedColor = Color.Lerp(Color.black, Color.red, Mathf.PingPong(Time.time, 1.5f));
        render.material.color = lerpedColor;
    }
    

    // Other methods
    public void Bump() {
        BumpParticles.Play();
    }
}