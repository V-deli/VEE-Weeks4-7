using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenrotation : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        Vector2 direction = mousePos - transform.position;
        transform.up = direction;
    }
}
