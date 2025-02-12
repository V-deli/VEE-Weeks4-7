using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playermoving : MonoBehaviour
{

    public float chaspeed = 5f;
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

    void Update()
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
        }
    }

    void FixedUpdate()
    {
        body.MovePosition(body.position + direction * chaspeed * Time.fixedDeltaTime);
    }

}