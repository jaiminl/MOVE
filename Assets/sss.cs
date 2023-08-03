using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sss : MonoBehaviour
{
    public int health = 5;
    public string poisonTag = "poison";
    public GameObject lose;
    private int currenthealth;
    private int totalpoisons;

    public TMP_Text healthText;

    private void Start()
    {
        
        currenthealth = health;
        totalpoisons = GameObject.FindGameObjectsWithTag(poisonTag).Length;
        UpdatehealhText();
        lose.SetActive(false);
    }

    private void Update()
    {
        
        int currenthealth = GameObject.FindGameObjectsWithTag(poisonTag).Length;
        int poisonsCollected = totalpoisons - currenthealth;
        this.currenthealth = health - poisonsCollected;

        UpdatehealhText();
    }

    private void UpdatehealhText()
    {
        healthText.text = "health: " + currenthealth.ToString();
        if(currenthealth == 0)
        {
              lose.SetActive(true);
        }
    }
}
