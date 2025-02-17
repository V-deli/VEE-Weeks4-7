using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI elements (explained in other scripts)

public class playermoving : MonoBehaviour
{

    public float chaspeed = 3f; //float for the characters default speed
    private Rigidbody2D body; //component in the inspector of the "player"
    

    public Slider speedSlider; //this is the slider that will alter the speed of the player, when moved around on screen when the unity projct is played
    public SpriteRenderer SpriteRenderer; //this is the spriterenderer component that can change the players sprites
    public Sprite[] spritesDirection; //this is an array with the purpose of storing all the player angle sprites that are dragged ijto the inspector since its public

    private Vector2 movement; //and this stores the players DIRECTION of movement (so that way if player is moving in a certain direction, I can attach the correct sprite to that direction)

    void Start() //once the game starts:
    {
        body = GetComponent<Rigidbody2D>(); //this gets a hold of the Rigidbody2d componemt (component thats on the player gameobject)
        if (speedSlider != null) //if the slider is not null: the speed slider is on
        { //set the speed of the slider to the speed of the character
            speedSlider.value = chaspeed;

        }
    }

    
    void Update()
    {
        if (speedSlider != null) //practically the same code from above
        {
            chaspeed = speedSlider.value; //links the slider to that of the character/players speed

        }

        Vector2 movement = new Vector2(movement.x = 0, movement.y = 0); //movement gets reset to 0 so that way the script knows which direction the player is moving in and that way the previous values dont get carried over

        //I SET Input.GetKeyKeyCode TO CORRELATE WITH EACH INDIVIDUAL CHARACTER SPRITE
        //this way the script knows that when: THAT key is pressed, THAT direction is occuring, therefore THAT sprite from the array must be displayed on the screen

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //when w OR uparrow keys are pressed...
        {
            movement.y = 1; //going UPP
            SpriteRenderer.sprite = spritesDirection[1]; //the second sprite in my array shown (which is the UP one)
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //when s OR downarrow keys are pressed...
        {
            movement.y = -1; //moving DOWN
            SpriteRenderer.sprite = spritesDirection[0]; //down sprite in array is shown
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //when a OR L-arrow keys are pressed...
        {
            movement.x = -1; //moving L
            SpriteRenderer.sprite = spritesDirection[2]; //left sprite in array is shown
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) //when d OR R-arrow keys are pressed...
        {
            movement.x = 1; //moving R
            SpriteRenderer.sprite = spritesDirection[3]; // right sprite in array is shown
        }

        transform.Translate(movement * chaspeed * Time.deltaTime);
        //moves the player with translate and times by deltatime for smooth movement frame time
    }
    }
