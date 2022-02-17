using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = speed + 0.8f * Time.deltaTime;
        Vector3 oldPosition = transform.position;
        Vector3 newPos = new Vector3(oldPosition.x, oldPosition.y, oldPosition.z - speed * Time.deltaTime);
        transform.position = newPos;
        
    }
}
