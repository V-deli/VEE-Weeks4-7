using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timerscript : MonoBehaviour
{
    Slider slider;
    public float myTimer;
    public TMP_Text message;
    public pickingupfood playerPickup;

    void Start()
    {
        slider = GetComponent<Slider>();
        message.text = "";
        
    }

   
    void Update()
    {
        myTimer += Time.deltaTime;
        //slider.value = myTimer % slider.maxValue;
        slider.value = myTimer;

        if (playerPickup.score >= 10)
        {
            message.text = "Winner";
        }

        else if (myTimer >= slider.maxValue)
        {
            message.text = "Game Over";
        }
        else
        {
            message.text = "";
        }
    }
}
