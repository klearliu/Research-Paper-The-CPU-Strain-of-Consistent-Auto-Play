using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class FireAttack : MonoBehaviour
{

    public Rigidbody2D fireBody;
    public float speed = 5f;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        fireBody.velocity = Vector2.right*speed;
    }

    private void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.GetComponent<GoblinHealth>()){
            coll.gameObject.GetComponent<GoblinHealth>().health -= damage;
            Destroy(gameObject);
        }
    }
}
