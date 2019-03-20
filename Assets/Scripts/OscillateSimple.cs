// Integrated Technology at BZAEDS
// Script to move an object from point A to Point B
// You need to drop this script into the GameObject you want to oscillate
// Determine which point will be defined for the transfortmations by
// dropping a GmaeObject into the Point A & B box, so our object moves inbetween those objects


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateSimple : MonoBehaviour {

    public Transform a, b, c;
    [Range(0, 1)]
    public float speed = .1F;

    void Update()
    {
        float pingPong = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(a.position, b.position, Time.time);
    }
}
