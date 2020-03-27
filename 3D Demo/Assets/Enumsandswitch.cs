using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumsandswitch : MonoBehaviour
{

    // didn't understand enums and switches all that well so this is me trying to practice//

    public int health;

    public string[] arrayString;

    public enum WeaponType
    {
        Sword,
        Staff,
        Dagger,
        Mace
    }

    public WeaponType weaponType;

    // Start is called before the first frame update
    void Start()
    {

        if (weaponType == WeaponType.Mace)
        {
            print("ouch oof your bones");
        }
        arrayString = new string[3];
        arrayString[0] = "Sword";
        arrayString[1] = "Potion";
        for (int i = 0; i < arrayString.Length; i++)
        {
            print(arrayString[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (weaponType)
        {
            case WeaponType.Dagger:
                print("Dagger");
                break;
            case WeaponType.Sword:
                print("Sword");
                break;
            case WeaponType.Mace:
                print("Mace");
                break;
            case WeaponType.Staff:
                print("Staff");
                break;
        }

        DamagePlayer(1);
        if (health <= 0)
        {
            print("Ouch oof my bones");
        }
    }

    public void DamagePlayer(int damage)
    {
        health -= damage;
    }
}
