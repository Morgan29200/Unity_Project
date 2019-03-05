using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using SimpleJSON;

public class Movement_Glass : MonoBehaviour
{

    public Vector3 pointB;
    public Vector3 pointA;
    public float maxSpeed = 1;
    public bool pressHit = false;
    public bool pressHit2 = false;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            pressHit = true;

        }


        if (pressHit == true)
        {
            pressHit2 = false;
            var change = maxSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pointB, change);

        }


        if (Input.GetKey(KeyCode.M))
        {
            pressHit2 = true;
        }

        if (pressHit2 == true)
        {
            pressHit = false;
            var change2 = maxSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, pointA, change2);
        }

    }

}
