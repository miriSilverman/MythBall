using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float stabilizationSpeed;
    [SerializeField] private float maxVelocity = 15f;

    private bool _dragging = false;
    private bool isStablizing = false; 

    public Rigidbody rb;
    private Vector3[] stablizedVectors;
    private Vector3 closestAxis;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.maxAngularVelocity = maxVelocity;
        stablizedVectors = new[]
        {
            transform.forward, -transform.forward, transform.right, -transform.right, transform.up, -transform.up
        };
        //rb.centerOfMass = transform.position;
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
            isStablizing = false;
            float x = Input.GetAxis("Mouse X") * rotationSpeed;
            float y = Input.GetAxis("Mouse Y") * rotationSpeed;

            if (Input.GetKey(KeyCode.LeftControl))
            {
                int sign = 1;
                var playerScreenPoint = Camera.main.WorldToScreenPoint(transform.position);
                if (Input.mousePosition.x < playerScreenPoint.x)
                {
                    sign = -1;
                }
                rb.AddTorque(Vector3.forward * (y * sign), ForceMode.Impulse);
            }

            else
            {
                rb.AddTorque(Vector3.down * x, ForceMode.Impulse);
                rb.AddTorque(Vector3.right * y, ForceMode.Impulse);
            }
        }

        else
        {
            
            //
            // if (rb.angularVelocity.magnitude < 0.01f)
            // {
            //     if (!isStablizing)
            //     {
            //         isStablizing = true;
            //         Stablize();
            //         Debug.DrawLine(rb.position, rb.position+transform.forward*10, Color.red, 3f);
            //         Debug.DrawLine(rb.position, rb.position+closestAxis*10, Color.blue, 3f);
            //     }
            //     
            //     rb.angularVelocity = Vector3.zero;
            //     
            //     Quaternion newRotation1 = Quaternion.FromToRotation(transform.forward, closestAxis);
            //     newRotation1 = Quaternion.Lerp(Quaternion.LookRotation(transform.forward), Quaternion.LookRotation(closestAxis),
            //         Time.fixedDeltaTime * stabilizationSpeed);
            //     
            //     
            //
            //     rb.MoveRotation(newRotation1); 
            //     
            // }
        }
    }



    private void Stablize()
    {
        float cos = 1;
        foreach (var vec in stablizedVectors)
        {
            var newCos = Vector3.Dot(vec, transform.forward);
            if (newCos < cos && newCos >= 0)
            {
                cos = newCos;
                closestAxis = vec;
            }
        }
  
    }
}

