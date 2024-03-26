using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour


{ public Controls controls;
    private bool readyToLaunch = true;
    public float launchForce;
    public Ball ball;
    private Rigidbody rb;
    public float speed = 10;
    public GameObject objectToAppear; 
    public float appearanceDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controls = new();
        controls.Enable();
        objectToAppear.SetActive(false);
    }

    public void Shooter()
    {
        float actualLaunchForce = Random.Range(launchForce * 0.8f, launchForce * 1.2f);
        rb.AddForce(Vector3.forward * actualLaunchForce, ForceMode.Impulse);
        StartCoroutine(ShowObjectAfterDelay());
    }

    IEnumerator ShowObjectAfterDelay()
    {
        yield return new WaitForSeconds(appearanceDelay);
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(true);
        }
    }

    public void Death()
    {
        transform.position = GameObject.FindGameObjectWithTag(Constants.Tags.RESTART).transform.position;
        rb.velocity = Vector3.zero;
        readyToLaunch = true;
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constants.Tags.DEATH)){
            Death();
        }
    }

    private void OnCollisionEnter(Collision collision) {
        var bumper = collision.gameObject.GetComponent<Bumpers>();
        if (bumper != null) {
            bumper.Bump();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (controls.Testing.BallShooter.WasReleasedThisFrame() && readyToLaunch == true){
            Shooter();
            readyToLaunch = false;
        }
    }  
}