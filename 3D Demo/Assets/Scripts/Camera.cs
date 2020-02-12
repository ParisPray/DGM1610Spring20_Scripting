using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]

public class Camera : MonoBehaviour
{
    private Camera cameraObj;

    // Start is called before the first frame update
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
