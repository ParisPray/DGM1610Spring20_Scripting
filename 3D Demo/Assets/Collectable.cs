using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Collectable : ScriptableObject
{
    public int powerLevel = 10;
    public Color collectableColor = Color.red;
    public Sprite collectableSprite;


}
