using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BracoModelo : MonoBehaviour
{
    public Transform Ob1,Ob2;
    public float gx,gy;
    float endpoint1,endpoint2;

private void Awake() {

    endpoint1 = -145.12f;
    endpoint2 = 123.99f;
    
}


    void Update()
    {
        
        Ob1.rotation = Quaternion.Euler(Ob1.rotation.x,endpoint1+gx,Ob1.rotation.z);
        Ob2.localRotation = Quaternion.Euler(endpoint2-gy,0,0);

    }

         void OnMessageArrived(string msg)
    {
        Debug.Log(msg);
        string[] splitData = msg.Split("|");
        Debug.Log(splitData[0]);
        Debug.Log(splitData[1]);
        gx=float.Parse(splitData[0]);
        gy=float.Parse(splitData[1]);
    }

    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }

}
