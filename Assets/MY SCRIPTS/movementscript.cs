using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    public float speed = 1f;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speed = speed * -1;
        }
        transform.position = pos;
    }
    void Go(float s)
    {
        speed = s;
    }
    void Stop()
    {
        speed = 0f;
    }
}
