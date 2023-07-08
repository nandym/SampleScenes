using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDeFantasmas : MonoBehaviour
{
   public GameObject Fantasma;
   public float Tempo; 

   private void Start() {
    StartCoroutine(Esperar(Random.Range(Tempo,Tempo*3)));
   }


    private IEnumerator Esperar(float Tempo)
    {
        while(true){
            yield return new WaitForSeconds(Tempo);
            Vector3 posicao = new Vector3(Random.Range(-6,6),Random.Range(-6,6),transform.position.z);
            Instantiate(Fantasma,posicao,transform.rotation);
        }
    }




}
