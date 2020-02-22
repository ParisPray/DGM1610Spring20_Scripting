using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]

public class Lightscript : MonoBehaviour
{
   
    public Light lightObj;

    // Start is called before the first frame update
    void Start()
    {
        lightObj.intensity = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
