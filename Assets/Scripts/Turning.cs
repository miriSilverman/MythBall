using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Turning : MonoBehaviour
{
    [SerializeField] private GameObject room;
    private Ease _moveEase = Ease.Linear;
    [SerializeField] private int numOfCube;
    
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Init();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
