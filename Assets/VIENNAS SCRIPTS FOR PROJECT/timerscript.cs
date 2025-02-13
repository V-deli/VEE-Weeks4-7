using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerscript : MonoBehaviour
{
    Slider slider;
    public float myTimer;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

   
    void Update()
    {
        myTimer += Time.deltaTime;
        slider.value = myTimer % slider.maxValue;
    }
}
