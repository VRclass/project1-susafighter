﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float speedTime = 2.0f; // modify the value to match the needed speed
    public GameObject anything;

    void Update()
    {

        // ...also rotate around the World's Y axis
        // commented out for experimentaion
        // transform.Rotate(0, Time.deltaTime, 0, Space.World);
        transform.RotateAround(anything.transform.position, Vector3.up, Time.deltaTime * speedTime);
    }
}