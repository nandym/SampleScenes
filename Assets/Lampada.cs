using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampada : MonoBehaviour
{
    public string Nome = "A";
    private Light LightC;
    private SerialController SController;

    private void Start() {
        LightC = GetComponent<Light>();
        SController = GameObject.Find("SerialController").GetComponent<SerialController>();

    }

    void LightToggle(){
        LightC.enabled = !LightC.enabled;
        SController.SendSerialMessage(Nome);
    } 


    void Evento(){
        LightToggle();
    }

}
