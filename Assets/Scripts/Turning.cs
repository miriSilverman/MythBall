using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Turning : MonoBehaviour
{
    [SerializeField] private GameObject room;
    [SerializeField] private int numOfCube;
    
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     RaycastHit hit;
        //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     if (Physics.Raycast(ray, out hit, 100f))
        //     {
        //         if (hit.transform != null)
        //         {
        //             Debug.Log(hit.transform.gameObject.name);
                    // if (hit.transform.gameObject.CompareTag("Turn"))
                    // {
                    //     switch (numOfCube)
                    //     {
                    //         case 1:
                    //             room.transform.DORotate(new Vector3(0, 0, 90), 10f);
                    //             break;
                    //         case 2:
                    //             room.transform.DORotate(new Vector3(0, 0, -90), 10f);
                    //             break;
                    //
                    //     }
                    // }
    
                // }
            // }
        // }
        
    }
    
    
    // public void turnButton()
    // {
    //     
    //     room.transform.DORotate(new Vector3(0, 0, 90), 10f);
    //
    // }
    // private void OnMouseDown()
    // {
    //     room.transform.DORotate(new Vector3(0, 0, 90), 10f);
    //
    // }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Ball"))
        {
            switch (numOfCube)
            {
                 case 1:
                     room.transform.DORotate(new Vector3(0, 0, 90), 10f);
                     break;
                 case 2:
                     room.transform.DORotate(new Vector3(0, 0, -90), 10f);
                     break;
            }
        }
    }
}
