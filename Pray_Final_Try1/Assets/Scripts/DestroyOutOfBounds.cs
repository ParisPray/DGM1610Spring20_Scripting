﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float TopBound = 30;
    private float lowerBound = -10;

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
    }
}
