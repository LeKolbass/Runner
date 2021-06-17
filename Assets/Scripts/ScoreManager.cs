using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreDisplay;
    public int CoinScore = 0;
    public Text CoinScoreDisplay;

    void Start()
    {

    }


    void Update()
    {
        scoreDisplay.text = score.ToString();
        score = score + 1;
        CoinScoreDisplay.text = CoinScore.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            CoinScore = CoinScore + 1;
            Destroy(other.gameObject);
        }
    }
}
