using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;

    public Slider slider;
    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        slider.value = health;

        if(health <= 0){
            Destroy(slider.gameObject);
            Destroy(gameObject);
        }
    }
}
