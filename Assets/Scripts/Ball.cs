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
    private bool _inWindArea;
    private GameObject _windArea;
    private WindArea _windAreaS;
    
    
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {

        if (_inWindArea)
        {
            _rb.AddForce(_windAreaS.direction * _windAreaS.strength);
        }
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        
        _rb.AddForce(movement*speed);
    }
    private void OnMouseDown()
    {
        room.transform.DORotate(new Vector3(0, 0, 90), 10f);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("windArea"))
        {
            _inWindArea = true;
            _windArea = other.gameObject;
            _windAreaS = _windArea.GetComponent<WindArea>();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("windArea"))
        {
            _inWindArea = false;
        }
    }
}
