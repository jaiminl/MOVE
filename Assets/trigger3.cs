using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class trigger3 : MonoBehaviour
{
    private Rigidbody rd;
    public int force = 5;
    private int score_num = 0;
    private int health_num = 5;
    public GameObject score;
    public GameObject win;
    public GameObject lose;
    public GameObject health;

    void Start()
    {
        rd = GetComponent<Rigidbody>();
        win.SetActive(false);
        lose.SetActive(false);
        score.GetComponent<TMP_Text>().text = "score: " + score_num.ToString();
        health.GetComponent<TMP_Text>().text = "health: " + health_num.ToString();
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
        if (collider.tag == "poison")
        {
            health_num--;
            health.GetComponent<TMP_Text>().text = "health: " + health_num.ToString();
            if (health_num == 0)
            {
                lose.SetActive(true);
            }
            Destroy(collider.gameObject);
        }
    }
}