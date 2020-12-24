using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableGlass : MonoBehaviour
{
    public float forceThreshold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        foreach (ContactPoint contact in other.contacts)
        {
            
            
            if (contact.thisCollider.name.Equals("Glass") || contact.thisCollider.CompareTag("Glass"))
            {
                float collisionForce = other.impulse.magnitude / Time.fixedDeltaTime;
                // Debug.Log("glass hit with force" + collisionForce);

                if (collisionForce > forceThreshold)
                {
                    contact.thisCollider.gameObject.SetActive(false);
                }
            }
            
            

        }

    }
}
