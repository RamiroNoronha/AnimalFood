using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Teste feito quando o IsTrigget não estava selecionado
    /* private void OnCollisionEnter(Collision collision)
     {
         Destroy(gameObject);
         Destroy(collision.gameObject);
     }*/

    //Funciona quando o IsTrigger está selecionado
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
