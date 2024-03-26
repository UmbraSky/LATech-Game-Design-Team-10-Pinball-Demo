using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisionWithObject : MonoBehaviour
{
    public GameObject objectToIgnore; // Reference to the GameObject to ignore collision with

    void Start()
    {
        if (objectToIgnore != null)
        {
            IgnoreCollision(gameObject, objectToIgnore);
        }
        else
        {
            Debug.LogWarning("Please assign a GameObject to ignore collision with.");
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
            Debug.LogWarning("One or both GameObjects do not have Collider components.");
        }
    }
}

