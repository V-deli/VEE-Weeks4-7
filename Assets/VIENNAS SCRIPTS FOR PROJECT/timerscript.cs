using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //using UI elements in inspector and in this script, that way script knows what I'm talking about when I mention UI in my script
using TMPro; //using UI text too, to allow script to access this element

public class timerscript : MonoBehaviour
{
    Slider slider; //the slider is the timer: looks like a clock visually
    public float myTimer; // this is the timer value which keeps track of the times thats elapsed 
    public TMP_Text message; //the actuall text element in the inspector/unity (it will display 1 of 2 messages during end state of game)
    public pickingupfood playerPickup; //mentioned script to include access here
    private bool gameEnded = false; //made a booolean that tracks if my game has ended or not 
    private float mtimer = 0f; //this tracks how long the messages will last being displayed on the screen for, starts off with 0 since I only want it to pop up for 2 seconds once the GAME ENDS

    void Start()
    {
        slider = GetComponent<Slider>(); //getting a hold of the slider/timer component UI gameobject
        message.text = ""; //making the message empty since I only want a message once the game ends...and this is when the game STARTS
        myTimer = 0f; //making the timer default set to 0
        slider.value = 0f; //making the slider value also set to 0 to match my float
        
    }

   
    void Update()
    {
        if (!gameEnded) // so if the game has not ended: then continue counting time and checking conditions
        {
            myTimer += Time.deltaTime; //the timer increases with deltatime: consistent per frame
            slider.value = myTimer; //sliders visual value set equal to the timer

            //END STATE 1: THE PLAYER WINS
            if (playerPickup.score >= 10) //"if" the players score reches 10 then...
            {
                playerPickup.score = 10; //the score stays at 10 and cant surpass 10
                message.text = "Winner"; //the text on screen will display this winner message
                gameEnded = true; //which means that the game has indeed ended: so the boolean is set to true
                mtimer = 0f; //the timer is reset to 0 to allow the player to play again
                playerPickup.score = 0; //the score is reset too since the game ended (play again)
                
            }
            //END STATE 2: THE PLAYER LOSES
            else if (myTimer >= slider.maxValue) //"if; the timer reaches its max valuse (which in this case is 30) then...
            {
                message.text = "Game Over"; //this message is shown/displayed on screen to view
                gameEnded = true; //game is over meaning boolean is true
                mtimer = 0f; //resets timer to 0
                playerPickup.score = 0; //resets score to 0
                
            }
        }
        else //this will activate t0: start counting down the message display timer
        {
            mtimer += Time.deltaTime; //delta time to set it to display evenly through frames
            if (mtimer >= 2f) //both messages (whichever game state happens) last on screen for 2 seconds before dissapearing
            {

                message.text = ""; //I want the message to clear
                myTimer = 0f; //resets the timer= new game
                slider.value = 0f; //resest timer
                gameEnded = false; //now the game is on again for to start over fresh
            }
        }
    }
}
