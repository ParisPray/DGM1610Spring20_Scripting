using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectableList : ScriptableObject
{
    // Start is called before the first frame update
    public List<Collectable> collectables;
}
