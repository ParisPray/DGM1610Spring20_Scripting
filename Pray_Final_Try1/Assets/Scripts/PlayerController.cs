using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    private float forwardInput;
    public float speed = 5f;
    public float turnSpeed = 5f;
    public Vector3 positionDirection;
    public CharacterController Controller;
    public GameObject projectilePrefab;

    private void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Controller.Move(move * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);


        }

        
    }
}

