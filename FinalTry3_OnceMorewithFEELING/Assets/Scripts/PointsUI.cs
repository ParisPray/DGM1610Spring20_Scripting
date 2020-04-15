using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUI : MonoBehaviour
{
    public IntData Points;
    public Text pointsText;

    public void DisplayPoints()
    {
        pointsText.text = Points.value.ToString();
    }
}
