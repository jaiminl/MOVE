using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{

    public GameObject bullet;  //�ӵ�Ԥ����

    void Update()
    {

        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))  //�������������������Ԥ����
        {
            Instantiate(bullet, transform.position, transform.rotation);  //����Ԥ����
        }
    }

}


