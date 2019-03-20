using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float xspeed = 2.0f;
 
  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xspeed, 0, 0);
        
    }
}
