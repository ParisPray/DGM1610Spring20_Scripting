using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]

public class TextBehavior : MonoBehaviour
{
    private Text textObj;

    // Start is called before the first frame update
    void Start()
    {
        textObj = GetComponent<Text>();
    }
    public void ChangeText(string message)
    {
        print(textObj);
        print(message);
        textObj.text = message;
    }
    public void ChangeText(IntData obj)
    {
        textObj.text = obj.value.ToString();
    }
}