using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; //I added TextMeshPro to handle UI text in this script

public class pickingupfood : MonoBehaviour
{
    public float pickupDistance = 2f; // made a float for the maximum distance within which food can be picked up
    public foodspawn foodSpawner; //included a ref. to my other script so I can have acess to its properties
    public TMP_Text scoretext; //made a text to display the score
    public int score = 0; // this will keep track of the players score (ill make it set equal to tmp tesxt)
    public AudioSource pickupfoodsound; //added an audio source for when the UI button is pressed to pick up food
    private GameObject closestfood; //made a gameobject to ref. the closest food sprite

    private void Start()
    {
        closestfood = null; //to start off, I want the gameobject set equall to null
        if (scoretext != null) //if statement: and if it is NOT null then...
        {
            scoretext.text = "Score:" + score.ToString() + "/10" ; //this will be displayed on the screen to view
            // the parts in brackets are displayed and dont change, the tostring is displaying the increasing score, which starts off at 0
        }
    }




    void Update()
    {
        FindClosestFood(); 
        //updates the void  FindClosestFood() below which loops/continously programmed to find the closest food item during each frame
    }
    public void Onfoodbuttonpressed() //below code is what happens when the on screen button is pressed
    {
        if (closestfood != null) //makes it set equal to not null: to make sure there is food sprites displayed on screen
        {
         SpriteRenderer sr = closestfood.GetComponent<SpriteRenderer>(); // to get a hold of the spriterenderer component of the closest food
            if (sr != null) // this makes sure that the sprite renderer exists on the screen before its able to be editied
            {
                sr.color = Color.green; //if that doesnt work ill do 0101... it works... changing the food sprite colour from the default white to green
            }
            score = score + 1; // the score increases plus 1 for each food sprite altered to green
            if (scoretext != null) //assigning TEXT before updating...
            {
                scoretext.text = "Score:" + score.ToString() + "/10"; //this will update the score to display the current/recent score
            }
            if (pickupfoodsound != null) //assigning AUDIO before playing
            {
                pickupfoodsound.Play(); //this line plays the chosen sound I added in the audio source of the inspector that was attached to the button
            }
        }
    }

    void FindClosestFood()
    {
        closestfood = null; // this will reset the closest food variable before the nezxt lines are activated
        float closestDistance = pickupDistance; // I set the initial closest distance equal to the max pickup distance


        for (int i = 0; i < foodSpawner.activateFood.Length; i++) // activatefood was from the other script: the array of active food items from the food spawner 
        {
            GameObject food = foodSpawner.activateFood[i]; //current food object
            if (food != null) //food is NOT null: food exists then...(do the following) 
            {
                // so the 2 lines below are there to calculate the difference in x and y coordinates between the player and the food
                float dx = transform.position.x - food.transform.position.x; //x
                float dy = transform.position.y - food.transform.position.y; //y
                //then this line will calculate the pythagorean theroem:  a2 + b2 = c2
                float d = Mathf.Sqrt(dx * dx + dy * dy); // d for distance, explained it further in my process work
                // dx times dx = square of hor. distance
                // dy times dy = square of vert. distance
                // math squrt =square root = square root of the sum gives me the hyp. between player sprite/me and food sprite/object
                if (d < closestDistance) // so "if" food is closer than the closest food then...
                {
                    closestfood = food; //this food will be set as the closest food...
                    closestDistance = d; //and update the value of the disatance
                }
            }

        }
    }

        }



    

