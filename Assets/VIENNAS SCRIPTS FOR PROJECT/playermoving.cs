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

        //float moveX = Input.GetAxisRaw("Horizontal");
        //float moveY = Input.GetAxisRaw("Vertical");

        //if (moveX != 0f)
        //{
        //    moveY = 0f;
        //}

        Vector2 movement = new Vector2(movement.x = 0, movement.y = 0);
        //transform.Translate(movement);

        if (Input.GetKey(KeyCode.W))
        {
            movement.y = 1;
            SpriteRenderer.sprite = spritesDirection[1];
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movement.y = -1;
            SpriteRenderer.sprite = spritesDirection[0];
        }
        else if (Input.GetKey(KeyCode.A))
        {
            movement.x = -1;
            SpriteRenderer.sprite = spritesDirection[2];
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movement.x = 1;
            SpriteRenderer.sprite = spritesDirection[3];
        }

        transform.Translate(movement * chaspeed * Time.deltaTime);
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