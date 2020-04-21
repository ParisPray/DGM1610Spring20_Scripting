using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObj : MonoBehaviour
{
    public KeyCode key1 = KeyCode.LeftArrow, key2 = KeyCode.RightArrow;
    public float direction1 = 0, direction2 = 180;


    void Update()
    {
        if (Input.GetKeyDown(key1))
        {
            transform.rotation = Quaternion.identity;
        }
        if (Input.GetKeyDown(key2))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void flipTransform(float value)
    {

        transform.Rotate(0, value, 0);
    }
}
