using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ccc : MonoBehaviour
{
    public string coinTag = "coin";
    public GameObject win;
    private int score = 0;
    private int currentscore;
    private int totalcoins;
    public TMP_Text scoreText;

    private void Start()
    {
        currentscore = score;
        totalcoins = GameObject.FindGameObjectsWithTag(coinTag).Length;
        UpdatescoreText();
        win.SetActive(false);
    }

    private void Update()
    {

        int currentcoins = GameObject.FindGameObjectsWithTag(coinTag).Length;
        int coinCollected = totalcoins - currentcoins;
        this.currentscore = coinCollected;

        UpdatescoreText();
    }

    private void UpdatescoreText()
    {
        scoreText.text = "score: " + currentscore.ToString();
        if (currentscore == 5)
        {
            win.SetActive(true);
        }
    }
}
