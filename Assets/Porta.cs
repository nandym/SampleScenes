using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    private bool Aberta=false;
    private Quaternion RotFinal;
    private void Start() {
        RotFinal= Quaternion.Euler(-90,0,-90);
    }
    void Evento(){
        Aberta=true;
        Debug.Log("Abrir");
    }

    private void Update() {
        if(Aberta){
            transform.rotation = Quaternion.Slerp(transform.rotation, RotFinal,Time.deltaTime*1f);
        }
    }


}
