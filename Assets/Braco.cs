using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Braco : MonoBehaviour
{

    public GameObject P1,P2;
    public Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        P1.transform.LookAt(new Vector3(Target.position.x,transform.position.y,Target.position.z));
        P2.transform.LookAt(new Vector3(-Target.position.x,Target.position.y,-Target.position.z));
    }
}
