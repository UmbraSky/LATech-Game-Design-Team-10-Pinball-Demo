using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionWithObject : MonoBehaviour
{
    // Reference to the GameObject to ignore collision with
    public GameObject objectToIgnore; 

    void Start()
    {
        if (objectToIgnore != null)
        {
            IgnoreCollision(gameObject, objectToIgnore);
        }
        else
        {
            Debug.LogWarning("Need an Object to Ignore, Assign one, LOL.");
        }
    }

    void IgnoreCollision(GameObject obj1, GameObject obj2)
    {
        Collider col1 = obj1.GetComponent<Collider>();
        Collider col2 = obj2.GetComponent<Collider>();

        if (col1 != null && col2 != null)
        {
            Physics.IgnoreCollision(col1, col2);
        }
        else
        {
            Debug.LogWarning("You need to add some collider elements, sillygoose.");
        }
    }
}

