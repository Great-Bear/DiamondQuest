using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRomb : MonoBehaviour
{
    void Update()
    {
        GetComponent<Text>().text = "" + ScoreAllCoins.ScoreRomb.ToString();
    }
}
