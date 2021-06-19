using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueBut : MonoBehaviour
{
    public GameObject PauseMenu;

    public void ContinueGame()
    {
        GameObject.Find("ClickSound").GetComponent<AudioSource>().Play();
        PauseMenu.SetActive(false);
        MenuBut.Pause = false ;
    }
}
