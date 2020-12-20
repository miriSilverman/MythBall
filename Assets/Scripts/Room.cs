using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    public bool _dragging = false;

    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            _dragging = false;
            Debug.Log("mouse left");
        }   
    }

    private void OnMouseDrag()
    {
        _dragging = true;
        Debug.Log("mouse detected" + Input.GetAxis("Mouse X"));
    }

    private void FixedUpdate()
    {
        if (_dragging)
        {
            Debug.Log("dragging");
            float x = Input.GetAxis("Mouse X") * rotationSpeed;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed;
            
            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
    }
}

