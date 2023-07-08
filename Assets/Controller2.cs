using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2 : MonoBehaviour
{
    public SerialController Ctrl;

    // Start is called before the first frame update
    void Start()
    {
        Ctrl.SendSerialMessage("Ola");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

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


}
