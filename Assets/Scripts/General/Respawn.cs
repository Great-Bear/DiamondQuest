using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respawn : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ScoreAllCoins.ScoreDiamont = 0;
        ScoreAllCoins.ScoreRomb = 0;
        lineHearth.FullHeath = 5;
        MenuBut.Pause = false;
    }
}
