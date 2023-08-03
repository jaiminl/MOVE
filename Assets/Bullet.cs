using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;  

    void Start()
    {
        Destroy(gameObject, 7f); 
    }

    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime * speed);         
    }

}