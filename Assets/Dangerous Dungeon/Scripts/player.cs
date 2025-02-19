using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float SPEED;
    //public float JUMP;

    //public bool JUMPON;

    //public AnimationCurve JUMP2;
    //[Range(0, 1)] public float t;

    void Start()
    {
        //JUMPON = false;        
    }

    void Update()
    {
        //MOVE
        Vector2 pos = transform.position;
        transform.Translate(Input.GetAxis("Horizontal")* SPEED * Time.deltaTime,0,0);
        transform.Translate(0, Input.GetAxis("Vertical") * SPEED * Time.deltaTime, 0);

        //Vector2 translatePos = transform.position;


        ////JUMP
        //if (JUMPON == false && Input.GetKeyDown(KeyCode.Space))
        //{
        //    JUMPON = true;
        //}

        ////TIME
        //if (JUMPON == true)
        //{
        //    transform.position = Vector2.up * JUMP2.Evaluate(t);

        //    t += Time.deltaTime;
        //    if (t > 1)
        //    {
        //        t = 0;
        //        JUMPON = false;
        //    }
        //}
    }
}
