using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gyroscope : MonoBehaviour
{
    private UnityEngine.Gyroscope gyroscope;

    private bool isSupported;

    public Text outText;
    
    // Start is called before the first frame update
    void Start()
    {
        isSupported = SystemInfo.supportsGyroscope;
        Debug.Log("Is Supported" + isSupported);
        gyroscope = Input.gyro;
        gyroscope.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        outText.text = "Altitude" + gyroscope.attitude;
        transform.rotation = Quaternion.Euler(-Input.gyro.attitude.eulerAngles.y, Input.gyro.attitude.eulerAngles.x, Input.gyro.rotationRateUnbiased.z);
    }
}
