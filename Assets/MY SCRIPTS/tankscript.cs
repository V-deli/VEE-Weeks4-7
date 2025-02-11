using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;

public class tankscript : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime  , 0, 0);
        Vector2 pos = transform.position;
        pos.x = transform.position.x;
        Vector2 screenPos = Camera.main.ScreenToWorldPoint(pos);

        if (screenPos.x > Screen.width)
        { 
        pos.x = Screen.width;
        }
        
    }
}
    