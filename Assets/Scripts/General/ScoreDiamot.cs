using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDiamot : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "" + ScoreAllCoins.ScoreDiamont.ToString();
    }
}
