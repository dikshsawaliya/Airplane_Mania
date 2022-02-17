using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Accelerometer : MonoBehaviour
{
    private bool isSupported;
    public float speed;

    public float rotSpeed = 3.0f;

    public GameObject explosion;
    public GameObject plane;
    public GameObject canvas;
    public Transform Planepos;

    private Vector3 accel;
    // Start is called before the first frame update
    void Start()
    {
        isSupported = SystemInfo.supportsAccelerometer;
        Debug.Log(isSupported);
        accel = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //accel.x = -Input.acceleration.x;
       // transform.Translate(accel * speed * Time.deltaTime);
        
        
        Vector3 oldPosition = transform.position;
        Vector3 newpos = new Vector3(oldPosition.x + Input.acceleration.x, oldPosition.y, oldPosition.z);
       transform.position = newpos;
        
        float steer = -Input.acceleration.x;
        transform.Rotate(steer * rotSpeed,0,0);
        
    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
           plane.SetActive(false);

            //SceneManager.LoadScene("SampleScene");
            Instantiate(explosion, Planepos.transform.position, Quaternion.identity);
            canvas.SetActive(true);
            
        }
    }
}