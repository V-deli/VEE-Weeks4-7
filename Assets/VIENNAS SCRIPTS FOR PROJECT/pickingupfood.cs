using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class pickingupfood : MonoBehaviour
{
    public float pickupDistance = 2f;
    //public GameObject[] foodSprites;
    public foodspawn foodSpawner;
    public TMP_Text scoretext;
    public int score = 0;
    public AudioSource pickupfoodsound;
    private GameObject closestfood;

    private void Start()
    {
        closestfood = null;
        if (scoretext != null)
        {
            scoretext.text = "Score:" + score.ToString() + "/10" ;
        }
    }




    void Update()
    {
        FindClosestFood(); //void
    }
    public void Onfoodbuttonpressed()
    {
        if (closestfood != null)
        {
         SpriteRenderer sr = closestfood.GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                sr.color = Color.green; //if that doesnt work ill do 0101
            }
            score = score + 1;
            if (scoretext != null)
            {
                scoretext.text = "Score:" + score.ToString() + "/10";
            }
            if (pickupfoodsound != null)
            {
                pickupfoodsound.Play();
            }
        }
    }

    void FindClosestFood()
    {
        closestfood = null;
        float closestDistance = pickupDistance; //


        for (int i = 0; i < foodSpawner.activateFood.Length; i++) // activatefood was from the other script
        {
            GameObject food = foodSpawner.activateFood[i];
            if (food != null)
            {
                float dx = transform.position.x - food.transform.position.x;
                float dy = transform.position.y - food.transform.position.y;

                float d = Mathf.Sqrt(dx * dx + dy * dy); //auto filled my math for me, d for distance
                if (d < closestDistance) //
                {
                    closestfood = food;
                    closestDistance = d; //
                }
            }

        }
    }

        }



    

