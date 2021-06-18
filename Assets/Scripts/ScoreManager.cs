using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public Text scoreDisplay;
    public static int CoinScore;
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
