using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    [Header("Gyro")]
    [SerializeField]
    float gx,gy,gz;

    void Update()
    {
        Vector3 GyroRotation = new Vector3(gx,gy,gz);
        transform.rotation = Quaternion.Euler(GyroRotation);
    }

 void OnMessageArrived(string msg)
    {
        Debug.Log(msg);
        string[] splitData = msg.Split("|");
        Debug.Log(splitData[0]);
        Debug.Log(splitData[1]);
        Debug.Log(splitData[2]);
        gx=float.Parse(splitData[0]);
        gy=float.Parse(splitData[1]);
        gz=float.Parse(splitData[2]);
    }

    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }




}
