using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 1;
    private static int goblinsDestroyed = 0;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (health <= 0)
        {
            goblinsDestroyed++;
            
            if (goblinsDestroyed == 1)
                Debug.Log("First goblin destroyed at: " + Time.time + " seconds since game started.");

            if (goblinsDestroyed == 2)
                Debug.Log("Second goblin destroyed at: " + Time.time + " seconds since game started.");

            if (goblinsDestroyed == 3)
                Debug.Log("Third goblin destroyed at: " + Time.time + " seconds since game started.");

            Destroy(gameObject);
        }
    }
}
