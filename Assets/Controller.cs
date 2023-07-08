using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{


public GameObject[] Objetos;



    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)){
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if(Physics.Raycast(ray,out hit)){


                if(hit.transform.tag=="Lampada"){
                    Debug.Log(hit.transform.tag);
                    hit.transform.SendMessage("Evento");
                }

             }


        }

    }



      void OnMessageArrived(string msg)
    {
       Objetos[int.Parse(msg)-1].SendMessage("Evento");

       
    }

    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }




}
