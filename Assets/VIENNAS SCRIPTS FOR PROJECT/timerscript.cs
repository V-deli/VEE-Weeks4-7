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
    private bool gameEnded = false;
    private float mtimer = 0f;

    void Start()
    {
        slider = GetComponent<Slider>();
        message.text = "";
        myTimer = 0f;
        slider.value = 0f;
        
    }

   
    void Update()
    {
        if (!gameEnded)
        {
            myTimer += Time.deltaTime;
            //slider.value = myTimer % slider.maxValue;
            slider.value = myTimer;

            if (playerPickup.score >= 10)
            {
                playerPickup.score = 10;
                message.text = "Winner";
                gameEnded = true;
                mtimer = 0f;
                playerPickup.score = 0; //to reset the score
                
            }

            else if (myTimer >= slider.maxValue)
            {
                message.text = "Game Over";
                gameEnded = true;
                mtimer = 0f;
                playerPickup.score = 0; //same code
                
            }
        }
        else
        {
            mtimer += Time.deltaTime;
            if (mtimer >= 2f) //messages last for on screen
            {

                message.text = "";
                myTimer = 0f; //resets the timer
                slider.value = 0f;
                gameEnded = false;
            }
        }
    }
}
