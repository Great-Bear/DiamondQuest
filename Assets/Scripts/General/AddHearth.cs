using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHearth : MonoBehaviour
{
    lineHearth lineHearth;
    private void Start()
    {
        lineHearth = GameObject.Find("Main Camera").GetComponent<lineHearth>();
    }
    public void addHearth()
    {
        if (ScoreAllCoins.ScoreRomb > 0)
        {
            lineHearth.FullHeath++;
            lineHearth.RedrawLineHearth();
            ScoreAllCoins.ScoreRomb--;
        }
    }
}
