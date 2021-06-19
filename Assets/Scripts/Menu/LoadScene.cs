using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string nameScene;

    public void LoadingScene()
    {
        ScoreAllCoins.ScoreDiamont = 0;
        ScoreAllCoins.ScoreRomb = 0;
        lineHearth.FullHeath = 5;
        MenuBut.Pause = false;
        SceneManager.LoadScene(nameScene);
    }
}
