using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class listsvsarrays : ScriptableObject
{
    // remember 2 go ask a classmate and study up on this.
    // also includes loop practice.

    public string[] stringList;
    public string singleString;

    // Start is called before the first frame update

        public void AddToLIst(string stringobj)
    {
        stringList.Add(stringobj);
    }

    public void SortList()
    {
        stringList.Sort();
    }
    public void RemoveFromList(string stringObj)
    {
        stringList.Remove(stringobj);
    }

   public void CheckList()
    {
        
        foreach (var obj in stringList)
        {
            if (obj == singleString)
            {
                Debug.Log(obj);
            }
        }
    }


   
    // Update is called once per frame
    void Update()
    {
        
    }
}
