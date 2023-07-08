using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteAlways]
public class Lanterna_Script : MonoBehaviour
{
    [Header("Variaveis")]
    [Tooltip("As variaveis")]
    //Distancia da luz da lanterna
    public float MaxDistance = 30f;
    [Header("Gyro")]
    [SerializeField]
    float gx,gy,gz;

    void Update()
    {
        Debug.DrawRay(transform.position,transform.forward* MaxDistance, Color.red);

        if(Application.isPlaying)
        {
        
                RodarObjeto();
                DestruirFantasma();

        }
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





    void RodarObjeto(){
        // Mudar a rotacao do objeto 
        Vector3 GyroRotation = new Vector3(gz,gx,0);

        transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(GyroRotation),Time.deltaTime*1f);
       
    }


    void DestruirFantasma(){

        //Cria um raio que deteta o primeiro objeto que toca, se for um fantasma, o fantasma e destruido

        RaycastHit hit;
        if(Physics.Raycast(origin:transform.position,direction:transform.forward ,maxDistance: MaxDistance, hitInfo:out hit)){
            if(hit.transform.tag=="Enemy")
            {
                Debug.Log("Hit");
                Destroy(hit.transform.gameObject);
            }
        }
    }


}
