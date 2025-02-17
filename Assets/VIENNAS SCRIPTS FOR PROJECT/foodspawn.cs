using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodspawn : MonoBehaviour
{
    public GameObject[] foodPrefabs; //array to store the food prefabs in, its public so I can drag the prefabs from the assests folder into the inspector that holds this script
    public float spawnTime = 20.5f; //float variable i made for the time when food is spawned (made it greater than the despawn time so it gives a brief pause on the screen before spawning the next batch of food prefebs
    public float despawnTime = 20f; // this is the time when the food gets despawned/removed/destroyed
    public Vector2 spawnOffset = new Vector2(3f, 3f); //this vector is for the spaceing between the food prefabs

    private float timer = 0f; //this flaot tracks the spawn intervals
    public GameObject[] activateFood = new GameObject[4]; //THIS array is specific for the prefabs that are being called on to the screen = it says 4 since 4 prefabs out of the total 10 are being displayed at a time.
    private Color normalColor = new Color(1f, 1f, 1f); //normal/default colour of the prefabs (technically white)


    private void Start()
    {
        SpawnFood(); //to start, I want to spawn the initial set of food when the game has begun
        //this calls the void spawnfood and everythig in it, its below in this script
    }


    private void Update()
    {
        timer += Time.deltaTime; //this increments the timer based on the time that has passed, but per frame

        if (timer >= spawnTime) //if statement meaning: once the right amount of time has passed
        {
            SpawnFood(); //..then I want the food to be spawned
            timer = 0f; //since the food has been spawned, the timer resets to allott for the next time slot (to repeat the same thing again)
        }
    }
    void SpawnFood()
    {
        for (int i = 0; i < activateFood.Length; i++) // so this loops through the activateFood array and remove any existing food objects before spawning new one
        {
            if (activateFood[i] != null) //"if" there are food in this slot
            {
                Destroy(activateFood[i]); //destroy food /remove it from the game
            }
        }
            for (int i =0; i <4;  i++) //this spawns a new row of 4 food objects/prefabs
        {
                 Vector2 spawnPosition = new Vector2(
                (i - 1) * spawnOffset.x, 0
                );
            //this will determine the position of where the food will appear...
            //and offests each food prefab hor.x
            // zero to keep the same vertical level

            if (foodPrefabs.Length > 0) //if the length of the array (10) is greater than 0 
            {
                //then hte code below will choose a "random" food prefab from the BIG-array and place it at the said position
                GameObject food = Instantiate(foodPrefabs[Random.Range(0, foodPrefabs.Length)], 
                    spawnPosition, Quaternion.identity); //this keeps the food up wirh no rotation
                SpriteRenderer sr = food.GetComponent<SpriteRenderer>(); //so this gets a hold of the spriterenderer component in order to chgne colour of the food prefabs
                if (sr != null) //if the sprite renderer is not null then...
                {
                    sr.color = normalColor; //set the food prefab's colour back to the default original of white
                }
                activateFood[i] = food; //and now I store the new spawned food into the spawned food array (the one that holds 4)
                Destroy(food, despawnTime); //then I made it so the food will be destroyed AFTER the despawn time which is 20 f seconds
            }
        } 
        }
            
    }

// NOTE: changed 2 rows of 5, to 1 row of 4 since when I distort screens width the prefabs dont look nice :(