using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectors : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            GameController.Instance.Collected();
            Destroy(gameObject);
        }

    }
}
