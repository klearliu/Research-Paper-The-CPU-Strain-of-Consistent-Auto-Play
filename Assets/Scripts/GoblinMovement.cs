using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinMovement : MonoBehaviour
{

    public Rigidbody2D goblinRBody;
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        goblinRBody.velocity = Vector2.left*speed;
    }
}
