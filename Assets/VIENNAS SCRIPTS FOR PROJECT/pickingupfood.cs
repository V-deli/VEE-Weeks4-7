using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickingupfood : MonoBehaviour
{
    public float pickupDistance = 2f;
    public GameObject[] foodSprites;
    private GameObject closestfood;

    private void Start()
    {
        closestfood = null;
    }




    void Update()
    {
        FindClosestFood(); //void

        if (Input.GetKeyDown(KeyCode.Space)
            && closestfood != null)
        {
            PickupFood(closestfood); //void
        }
    }

        void FindClosestFood()
        {
            closestfood = null;
            float closestDistance = pickupDistance; //


            for ( int i = 0; i < foodSprites.Length; i++ )
            {
            float dx = transform.position.x - foodSprites[i].transform.position.x;
            float dy = transform.position.y - foodSprites[i].transform.position.y;

            float distance = Mathf.Sqrt( dx * dx + dy * dy ); //auto filled my math for me

                 if ( distance < pickupDistance )
                {
                    closestfood = foodSprites[i];
                    closestDistance = distance; //
                }
            }
        }
        void PickupFood(GameObject food)
        {
        food.transform.parent = transform;
        
        food.transform.localPosition = new Vector2 (0f, 1f); //

        //good// GameObject pickedFood = Instantiate(food, transform.position, Quaternion.identity);
        //good//pickedFood.transform.parent = transform;
        //good// pickedFood.transform.localPosition = new Vector3(); //0 0 0 

        foodspawn foodScript = food.GetComponent <foodspawn>();

        if ( foodScript != null )
        {
            foodScript.PickUpFood(); //the error I got was a typo OML that took a while to realse

        }



    }
}
