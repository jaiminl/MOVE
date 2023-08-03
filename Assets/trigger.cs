using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trigger : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "coin")
        {
           
            Destroy(collider.gameObject);
        }
        if (collider.tag == "poison")
        {
            
            Destroy(collider.gameObject);
        }
    }
}
