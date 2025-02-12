using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoving : MonoBehaviour
{

        public float chaspeed = 5f;
        public Rigidbody2D body;
        public Animator anim;

        private Vector2 direction;

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
        }

        void FixedUpdate()
        {
            body.MovePosition(body.position + direction * chaspeed * Time.fixedDeltaTime);
        }
    }