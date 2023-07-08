using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
   public float Velocidade;

    private void Start() {
        Destroy(this.gameObject,30f);
    }


    void Update()
    {

        transform.Translate(-transform.forward * Time.deltaTime * Velocidade);

    }
}
