using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermoving : MonoBehaviour
{

    public float chaspeed = 3f;
    public Rigidbody2D body;
    public Animator anim;
    public Slider speedSlider;

    private Vector2 direction;

    void Start()
    {
        if (speedSlider != null)
        {
            speedSlider.value = chaspeed;

        }
    }

    private float GetChaspeed()
    {
        return chaspeed;
    }

    void Update()//float chaspeed)
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        if (direction.x != 0 || direction.y != 0)
        {
            anim.SetFloat("Horizontal", direction.x);
            anim.SetFloat("Vertical", direction.y);
        }

        anim.SetFloat("Speed", direction.sqrMagnitude);

        if (speedSlider != null)
        {
            chaspeed = speedSlider.value;
          //  float newSpeed = speedSlider.value;

          ////  if (chaspeed! = newSpeed)
          //  {
          //      chaspeed = newSpeed;
          //  }
        }
    }


void FixedUpdate()
{
    body.MovePosition(body.position + direction * chaspeed * Time.fixedDeltaTime);
}

}