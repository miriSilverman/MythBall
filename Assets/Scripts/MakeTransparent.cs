using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MakeTransparent : MonoBehaviour
{
    [SerializeField] private Renderer renderer;

    [SerializeField] private Transform roomTransform;
    // [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform ballTransform;
    [SerializeField] private float upperAngle;
    [SerializeField] private float lowerAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // RaycastHit hit = new RaycastHit();
        // var ray = Physics.Linecast(cameraTransform.position, ballTransform.position, out hit);
        // if (ray)
        // {
        //     hit.
        //     Debug.Log("blocked");
        // }
     
        // if(Physics.Raycast(cameraTransform.position, cameraTransform.position - ballTransform.position, out hit))
        // {
        //     if (hit.)
        //     {
        //         
        //     }
        //     if(hit.gameObject.tag == player.tag && Vector3.Angle(enemy.transform.forward, enemy.transform.position - player.transform.position) <= fieldOfView / 2)
        //         seePlayer = true;
        // }

        float x = roomTransform.rotation.x;
        // Debug.Log(x);


        if (x > lowerAngle && x < upperAngle)
        {
            renderer.shadowCastingMode = ShadowCastingMode.ShadowsOnly;
        }
        else
        {
            renderer.shadowCastingMode = ShadowCastingMode.On;
             
        }
    }
}
