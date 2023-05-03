using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collision : MonoBehaviour
{
    private Rigidbody rd;
    public int force = 5;
    private int score_num = 0;
    public GameObject score;
    public GameObject win;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        win.SetActive(false);
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v) * force);
    }
        void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "coin")
        {
            score_num++;
            score.GetComponent<TMP_Text>().text = "score: " + score_num.ToString();
            if (score_num == 5)
            {
                win.SetActive(true);
            }
                Destroy(collider.gameObject);
        }
    }
}