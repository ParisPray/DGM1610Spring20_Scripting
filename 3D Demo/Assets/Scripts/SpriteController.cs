using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Sprite))]


public class SpriteController : MonoBehaviour
{
    public Color spriteColor = Color.red;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent < SpriteRenderer >();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
