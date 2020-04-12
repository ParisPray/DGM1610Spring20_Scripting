using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject 
{
    

    // Start is called before the first frame update
    public int value;


    public void changeValue(int newvalue)
    {
        value = newvalue;
    }
}
