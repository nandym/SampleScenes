using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadWrite : MonoBehaviour
{
public SerialController Controller;


  void OnMessageArrived(string msg)
    {
     Debug.Log(msg);
    }

    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }

private void Update() {
    Controller.SendSerialMessage("2");
}



}
