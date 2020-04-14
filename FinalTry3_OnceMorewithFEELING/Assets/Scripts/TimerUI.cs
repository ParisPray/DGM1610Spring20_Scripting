using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public IntData time;
    public Text timerText;

    public void DisplayTimer()
    {
        timerText.text = time.value.ToString();
    }
}
