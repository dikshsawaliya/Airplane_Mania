using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steer = Input.acceleration.x;
        transform.Rotate(steer,0,0);
        //transform.Translate(steer,0,0);
    }
}
