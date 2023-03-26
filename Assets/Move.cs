
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float MoveSpeed;
    int speed = 1;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * MoveSpeed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down * speed);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up * speed);

        }
    }
}
