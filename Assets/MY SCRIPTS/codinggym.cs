using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class codinggym : MonoBehaviour
{
    public float moveSpeed = 5f;
    //private 
    
     void Start()
    {
       
    }

    
    void Update()
    {
        Vector3 gotoDirection = Vector3.zero;
        //up
        if(Input.GetKey(KeyCode.UpArrow))
        {
            gotoDirection += Vector3.up;
        }
        //dwn
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gotoDirection += Vector3.down;
        }
        //L
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gotoDirection += Vector3.left;
        }
        //R
        if (Input.GetKey(KeyCode.RightArrow))
        {
                gotoDirection += Vector3.right;
        }
        transform.position += gotoDirection *moveSpeed *Time.deltaTime;
    }
}
