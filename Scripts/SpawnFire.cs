using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnFire : MonoBehaviour
{

    public GameObject firePrefab;
    public float coolDown = 2f;
    private float timer;
    private int fired = 0;

    // Start is called before the first frame update
    void Start()
    {
        timer = coolDown;
    }

    // Update is called once per frame
    void Update()
    {
        // Every 1s fire is launched
        timer -= Time.deltaTime;
        if(timer <= 0 && fired < 3){
            Instantiate(firePrefab, transform.position, Quaternion.identity);
            fired += 1;
            timer = coolDown;
        }

        // Everytime spacebar is pressed launch fire
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(firePrefab, transform.position, Quaternion.identity);
        }
    }
}
