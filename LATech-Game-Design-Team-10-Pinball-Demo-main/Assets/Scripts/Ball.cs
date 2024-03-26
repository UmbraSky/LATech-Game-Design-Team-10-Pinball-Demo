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
    public int pressedCount;
    public int ballLives;
    public int gameScore;
    public int recordScore;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controls = new();
        controls.Enable();
        objectToAppear.SetActive(false);
        pressedCount = 0;
        ballLives = 5;
        gameScore = 0;
    }

    private void OnDisable() 
    {
        PlayerPrefs.SetInt(Constants.PlayerPrefs.RECORDSCORE, recordScore);
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
        ballLives--;
        scoreAmount(Constants.Points.UPDATE);
        if (objectToAppear != null)
        {
            objectToAppear.SetActive(false);
        }
        if (ballLives < 0){
            // replace with Game Over
            print("You are dead, bucko");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Constants.Tags.DEATH)){
            Death();
        }
        else if (other.CompareTag(Constants.Tags.SCORECIRCLE)){
            var sCircle = other.GetComponent<ScoreCircles>();
            sCircle.Press();  
            scoreAmount(Constants.Points.PRESS);     
            pressedCount++; 
            if (pressedCount == 3){
                scoreAmount(Constants.Points.UNLOCK);
                print("UNLOCK JACKPOT!");
            }     
        }
    }

    private void OnCollisionEnter(Collision collision) {
        var bumper = collision.gameObject.GetComponent<Bumpers>();
        if (bumper != null) {
            bumper.Bump();
            scoreAmount(Constants.Points.BUMP);
        }
    }

    public void scoreAmount(int amount)
    {
        gameScore += amount;
        if (gameScore > recordScore) {
            recordScore = gameScore;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (controls.Testing.BallShooter.WasReleasedThisFrame() && readyToLaunch == true){
            Shooter();
            readyToLaunch = false;
        }
        else {gameScore++;}
    }  
}