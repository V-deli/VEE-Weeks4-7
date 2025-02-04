using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public float health = 10f;
    public Slider Slider;
    void Start()
    {
        
    }

  
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            TakeDamage(1);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
