using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class Mapeamento : MonoBehaviour
{
    public float Angulo=0;
    public float Distancia=10f;
    public GameObject ObjetoDesenho;
    public float Duracao=1;
    private Vector3 PontoIni,PontoFinal;



private void Awake() {
    PontoIni = transform.forward * Distancia;
    PontoFinal = PontoIni;

}

private void Update() {
    
Debug.DrawRay(transform.position,transform.forward*Distancia,Color.blue);
transform.rotation = Quaternion.Euler(0,Angulo,0);

PontoIni = transform.forward * Distancia;
Debug.DrawLine(PontoIni,PontoFinal,Color.red,1f);

if(Application.isPlaying){
    GameObject OB = Instantiate(ObjetoDesenho,PontoIni,transform.rotation);
    Destroy(OB,Duracao);
}


PontoFinal= PontoIni;
}


     void OnMessageArrived(string msg)
    {
        string[] splitData = msg.Split("|");
        Angulo=float.Parse(splitData[1]);
        Distancia=float.Parse(splitData[2]);

    }

    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }





}
