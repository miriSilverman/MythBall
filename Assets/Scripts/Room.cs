using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private bool _dragging = false;

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

        }   
    }

    private void OnMouseDrag()
    {
        _dragging = true;

    }

    private void FixedUpdate()
    {
        if (_dragging)
        {

            float x = Input.GetAxis("Mouse X") * rotationSpeed;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed;
            
            rb.AddTorque(Vector3.down * x);
            rb.AddTorque(Vector3.right * y);
        }
    }
}

