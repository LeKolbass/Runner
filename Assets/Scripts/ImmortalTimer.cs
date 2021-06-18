using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImmortalTimer : MonoBehaviour
{

    public float time = 7;
    private Text timerText;
    public static bool isImmortal;
    public static int CoinScore;

    void Start()
    {
        timerText = GetComponent<Text>();
        timerText.text = "";
    }

    void Update()
    {

        if (PlayerController.isImmortal == true)
        {
            time -= Time.deltaTime;
            timerText.text = "Immortal " + (Mathf.Round(time)).ToString();
        }
        else if (ScoreManager.CoinScore >= 10)
        {
            timerText.text = "Press 'I' to buy immortal";
            time = 7;
        }
        else
        {
            timerText.text = "";
            time = 7;
        }


    }
}
