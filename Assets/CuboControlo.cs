using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class CuboControlo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position,Vector3.right*10,Color.red);
        Debug.DrawRay(transform.position,transform.right*10,Color.blue);
    }
    void OnConnectionEvent(bool connected){}

    void OnMessageArrived(string msg){
        if(msg=="1"){
        transform.position+=transform.right;

        }
        if(msg=="2"){
        transform.position+=-transform.right; 
        }

    }

}
