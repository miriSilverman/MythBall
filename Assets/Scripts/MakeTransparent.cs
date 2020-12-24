using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MakeTransparent : MonoBehaviour
{
    [SerializeField] private Renderer renderer;
    [SerializeField] private GameObject curObj;
    [SerializeField] private Transform roomTransform;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform ballTransform;
    [SerializeField] private float upperAngle;
    [SerializeField] private float lowerAngle;
    [SerializeField] private String tag;


    void Update()
    {
        
        var ray = new Ray(cameraTransform.position, ballTransform.position - cameraTransform.position);
        RaycastHit hit;
        LayerMask mask = 1 << 8;
        if (Physics.Raycast(ray, out hit,Vector3.Distance(cameraTransform.position, ballTransform.position), mask))
        {
            GameObject go = hit.transform.gameObject;
            // Debug.Log(go.name);
           
            // if (go == curObj)
            if (go.name == "BoxRoom")
            {
                // Debug.Log(go.name);

                // renderer.shadowCastingMode = ShadowCastingMode.ShadowsOnly;

            }
            else
            {
                renderer.shadowCastingMode = ShadowCastingMode.On;

            
            }

        }
  
     
        // float x = roomTransform.rotation.x;
        // // Debug.Log(x);
        //
        //
        // if (x > lowerAngle && x < upperAngle)
        // {
        //     renderer.shadowCastingMode = ShadowCastingMode.ShadowsOnly;
        // }
        // else
        // {
        //     renderer.shadowCastingMode = ShadowCastingMode.On;
        //      
        // }
    }
}
