using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCircles : MonoBehaviour
{
    private bool pressedCheck;
    private Renderer render;
    Color defaultColor = Color.white;
    Color activeColor = Color.red;
    public Ball ball;
    private bool unlockState;
    public GameObject[] allCircles;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<Ball>();
        render = GetComponent<Renderer>();
        render.material.color = defaultColor;
        pressedCheck = false;
        allCircles = GameObject.FindGameObjectsWithTag("ScoreCircle");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.pressedCount == 3){
            ball.pressedCount = 0;
            Unlock();
        }
    }
    public void Press()
    {
        if (pressedCheck == false){
            pressedCheck = true;
            render.material.color = activeColor;
        }
    }

    public void Unlock()
    {
        foreach (GameObject circle in allCircles)
        {
            circle.GetComponent<ScoreCircles>().pressedCheck = false;
            circle.GetComponent<ScoreCircles>().render.material.color = defaultColor;
        }
    }
}
