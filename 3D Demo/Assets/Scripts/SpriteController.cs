using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Sprite))]


public class SpriteController : MonoBehaviour
{
    public Color spriteColor = Color.red;
    private SpriteRenderer sprite;
    private CharacterController controller;
    public float Speed = 20f;
    public Vector2 positionDirection;
    public float jumpForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent < SpriteRenderer >();
        controller = GetComponent<CharacterController>();
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * Speed);

        if (Input.GetButtonDown("Jump"))
        {
            positionDirection.y = jumpForce; 
        }
         
    }
}
