using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private Collider realHole; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("got here");
            Collider ball = other.gameObject.GetComponent<Collider>();
            Physics.IgnoreCollision(realHole, ball, true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {

            Debug.Log("out");

            Collider ball = other.gameObject.GetComponent<Collider>();
            Physics.IgnoreCollision(realHole, ball, false);
        }
    }
}
