using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermoving : MonoBehaviour
{

    public float chaspeed = 3f;
    private Rigidbody2D body;
    

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

    
    void Update()//float chaspeed)
    {
        if (speedSlider != null)
        {
            chaspeed = speedSlider.value;

        }

        Vector2 movement = new Vector2(movement.x = 0, movement.y = 0);
        

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            movement.y = 1;
            SpriteRenderer.sprite = spritesDirection[1];
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movement.y = -1;
            SpriteRenderer.sprite = spritesDirection[0];
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1;
            SpriteRenderer.sprite = spritesDirection[2];
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1;
            SpriteRenderer.sprite = spritesDirection[3];
        }

        transform.Translate(movement * chaspeed * Time.deltaTime);
        
    }
    }
