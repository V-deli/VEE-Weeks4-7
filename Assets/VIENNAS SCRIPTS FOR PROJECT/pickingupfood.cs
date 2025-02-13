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
            


            for ( int i = 0; i < foodSprites.Length; i++ )
            {
            float dx = transform.position.x - foodSprites[i].transform.position.x;
            float dy = transform.position.y - foodSprites[i].transform.position.y;

            float distance = Mathf.Sqrt( dx * dx + dy * dy ); //auto filled my math for me

                 if ( distance < pickupDistance )
                {
                    closestfood = foodSprites[i];
                }
            }
        }
        void PickupFood(GameObject food)
        {
        foodspawn foodScript = food.GetComponent <foodspawn>();

        if ( foodScript != null )
        {
            foodScript.PickUpFood(); //the error I got was a typo OML that took a while to realse
              
        }



    //    Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Vector2 direction = mousePos - (Vector2)transform.position;
    //    transform.up = direction;
    //}
    //public void Drop()
    //{
    //    transform.parent = null;
    //    Destroy(gameObject, 5);
    }
}
