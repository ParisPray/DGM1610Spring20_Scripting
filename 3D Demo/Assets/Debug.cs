﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Debug : ScriptableObject
{
   public void OnDebug(string message)
    {
        Debug.log("Debug");
    }
}
