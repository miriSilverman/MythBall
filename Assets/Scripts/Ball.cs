using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private GameObject room;

    private Rigidbody _rb;
    
    
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        
        //_rb.AddForce(movement*speed);
    }
    private void OnMouseDown()
    {
        room.transform.DORotate(new Vector3(0, 0, 90), 10f);

    }
}
