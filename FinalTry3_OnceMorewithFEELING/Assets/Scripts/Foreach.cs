using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Foreach : MonoBehaviour
{
    public GameObject[] powerups;
    public List <GameObject> powerupsList;
    public bool canRun = true;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < powerups.Length; i++)
        {
            print(powerups[i]);
        }

        foreach (GameObject obj in powerupsList)
        {
            print(obj);
        }

        
      
    }

}
