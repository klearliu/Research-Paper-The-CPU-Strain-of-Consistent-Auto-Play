using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinAttack : MonoBehaviour
{
    public int damage = 4;

    /*
    If we hit a 2d collider it will automatically reduce the object's health based on damage variable
    */
    private void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.GetComponent<BaseHealth>()){
            coll.gameObject.GetComponent<BaseHealth>().health -= damage;
            Destroy(gameObject);
        }
    }
}
