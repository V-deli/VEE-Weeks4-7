using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermoving : MonoBehaviour
{

    public float chaspeed = 3f;
    private Rigidbody2D body;
    //public Animator anim;

    public Slider speedSlider;
    public SpriteRenderer SpriteRenderer;
    public Sprite[] spritesDirection;

    private Vector2 movement;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        if (speedSlider != null)
        {
            speedSlider.value = chaspeed;

        }
    }

    //private float GetChaspeed()
    //{
    //    return chaspeed;
    //}

    void Update()//float chaspeed)
    {
        if (speedSlider != null)
        {
            chaspeed = speedSlider.value;

        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement = movement * chaspeed * Time.deltaTime;
        transform.Translate(movement);

        if (movement.x > 0)
        {
            SpriteRenderer.sprite = spritesDirection[3];
        }
        else if (movement.x < 0) 
            {
            SpriteRenderer.sprite = spritesDirection[2];
        }
        else if (movement.y < 0)
        {
            SpriteRenderer.sprite = spritesDirection[1];
        }
        else if (movement.y < 0)
        {
            SpriteRenderer.sprite = spritesDirection[0];
        }

        //anim.SetFloat("Speed", direction.sqrMagnitude);

        //if (speedSlider != null)
        //{
        //    chaspeed = speedSlider.value;
          //  float newSpeed = speedSlider.value;

          ////  if (chaspeed! = newSpeed)
          //  {
          //      chaspeed = newSpeed;
          //  }
        }
    }


//void FixedUpdate()
//{
//    body.MovePosition(body.position + direction * chaspeed * Time.fixedDeltaTime);
//}

//}