using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerMovement : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;

    // [SerializeField] Vector3 _distanceFromBall;

    [SerializeField] private float yHight;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = ballTransform.position;
        transform.position = new Vector3(pos.x, yHight, pos.z);

    }
}
