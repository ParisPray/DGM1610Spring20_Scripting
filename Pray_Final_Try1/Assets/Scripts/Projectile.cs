using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float TopBound = 30;
    private float lowerBound = -10;
    public float speed;
    public GameObject enemy;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if object leaves players view in the game, remove that object.
        if (transform.position.z > TopBound)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
       
        Destroy(enemy);
        Destroy(projectile);
    }
}
