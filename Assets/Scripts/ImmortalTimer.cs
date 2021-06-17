using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImmortalTimer : MonoBehaviour
{

    public float time = 7;
    private Text timerText;
    public static bool isImmortal;

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
        else
        {
            timerText.text = "";
            time = 7;
        }


    }
}
